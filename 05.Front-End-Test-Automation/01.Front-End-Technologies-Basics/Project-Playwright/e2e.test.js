const { test, expect } = require('@playwright/test');

const host = 'http://localhost:3000';

test('Register: valid data', async ({ page }) => {
    const email = `kris${Date.now()}@abv.bg`;

    await page.goto(host);
    await page.click('text=Register');
    await page.waitForSelector('input[name="email"]');

    await page.fill('input[name="email"]', email);
    await page.fill('input[name="password"]', '123456');
    await page.fill('input[name="confirm-password"]', '123456');

    await Promise.all([
        page.waitForNavigation(),
        page.click('input[type="submit"]')
    ]);

    await expect(page).toHaveURL(host);     
    await expect(page.locator('text=Logout')).toBeVisible();
});

test.describe('Front-End Authentication Tests', () => {

    test('Register: empty fields', async ({ page }) => {
        await page.goto(host);
        await page.click('text=Register');
        await page.waitForSelector('input[name="email"]');
        await page.fill('input[name="email"]', '');
        await page.fill('input[name="password"]', '');
        await page.fill('input[name="confirm-password"]', '');
        await page.click('input[type="submit"]');
        await expect(page).toHaveURL(host + '/register');
    });

    test('Login: valid credentials', async ({ page }) => {
        await page.goto(host);
        await page.click('text=Login');
        await page.waitForSelector('input[name="email"]');

        await page.fill('input[name="email"]', 'peter@abv.bg');
        await page.fill('input[name="password"]', '123456');

        await Promise.all([
            page.waitForNavigation(),
            page.click('input[type="submit"]')
        ]);

        await expect(page).toHaveURL(host); 
        await expect(page.locator('text=Logout')).toBeVisible(); 
    });

    test('Login: empty fields', async ({ page }) => {
        await page.goto(host);
        await page.click('text=Login');
        await page.waitForSelector('input[name="email"]');

        await page.fill('input[name="email"]', '');
        await page.fill('input[name="password"]', '');

        await page.click('input[type="submit"]');
        await expect(page).toHaveURL(host + '/login');
    });

    test('Logout', async ({ page }) => {
        await page.goto(host);
        await page.click('text=Login');
        await page.waitForSelector('input[name="email"]');

        await page.fill('input[name="email"]', 'peter@abv.bg');
        await page.fill('input[name="password"]', '123456');

        await Promise.all([
            page.waitForNavigation(),
            page.click('input[type="submit"]')
        ]);
        await expect(page.locator('text=Logout')).toBeVisible();
        await Promise.all([
            page.waitForNavigation(),
            page.click('text=Logout')
        ]);
        await expect(page).toHaveURL(host);
        await expect(page.locator('text=Login')).toBeVisible();
    });

});

test.describe('Navigation Bar for Logged-In User', () => {

    test('Verify navigation bar links visibility for logged-in user', async ({ page }) => {
        const password = '123456';

        await page.goto(host);
        await page.click('text=Login');
        await page.fill('input[name="email"]', 'peter@abv.bg'); 
        await page.fill('input[name="password"]', password);
        await page.click('input[type="submit"]');
        await page.waitForTimeout(1000); 
        await expect(page.locator('text=All Games')).toBeVisible();
        await expect(page.locator('text=Logout')).toBeVisible();
        await expect(page.locator('text=Login')).toHaveCount(0);
        await expect(page.locator('text=Register')).toHaveCount(0);
    });

});

test.describe('Navigation Bar for Guest User', () => {

    test('Verify navigation bar links visibility for guest user', async ({ page }) => {
        await page.goto(host);
        await expect(page.locator('text=Login')).toBeVisible();
        await expect(page.locator('text=Register')).toBeVisible();
        await expect(page.locator('text=Create Game')).not.toBeVisible();
        await expect(page.locator('text=Logout')).not.toBeVisible();
    });

});

const user = {
    email: 'peter@abv.bg',
    password: '123456'
};

test.describe('Front-End CRUD Operations Tests', () => {

    test.beforeEach(async ({ page }) => {
        await page.goto(host);
        await page.click('text=Login');
        await page.waitForSelector('input[name="email"]');
        await page.fill('input[name="email"]', user.email);
        await page.fill('input[name="password"]', user.password);
        await page.click('input[type="submit"]');
        await expect(page).toHaveURL(host);
    });

    test('Create a Game with Empty Fields', async ({ page }) => {
        await page.click('text=Create Game');
        await page.waitForSelector('form'); 
        await page.click('input[type="submit"]');
        await expect(page).toHaveURL(host + '/create');
    });

});

let game = {
    title: '',
    category: '',
    maxLevel: '99',
    imageUrl: 'https://jpeg.org/images/jpeg-home.jpg',
    summary: 'This is an amazing game!'
};

test.describe('Front-End CRUD Operations Tests', () => {

    test.beforeEach(async ({ page }) => {
        await page.goto(host);
        await page.click('text=Login');
        await page.waitForSelector('input[name="email"]');
        await page.fill('input[name="email"]', user.email);
        await page.fill('input[name="password"]', user.password);
        await page.click('input[type="submit"]');
        await expect(page).toHaveURL(host);
    });

    test('Create a Game with Valid Input Values', async ({ page }) => {
        const timestamp = Date.now();
        game.title = `Game ${timestamp}`;
        game.category = `Category ${timestamp}`;
        await page.click('text=Create Game');
        await page.waitForSelector('form');
        await page.fill('input[name="title"]', game.title);
        await page.fill('input[name="category"]', game.category);
        await page.fill('input[name="maxLevel"]', game.maxLevel);
        await page.fill('input[name="imageUrl"]', game.imageUrl);
        await page.fill('textarea[name="summary"]', game.summary);
        await page.click('input[type="submit"]');
        await expect(page).toHaveURL(host);
        await expect(page.locator(`text=${game.title}`)).toBeVisible();
    });

});

test.describe('Front-End Home Page Tests', () => {

    test('Guest user sees correct home page content', async ({ page }) => {
        await page.goto(host);
        const welcomeMessage = page.locator('h1', { hasText: 'GamesPlay' });
        await expect(welcomeMessage).toHaveText('GamesPlay');
        const gamesListTitle = page.locator('h1', { hasText: 'Latest Games' });
        await expect(gamesListTitle).toHaveText('Latest Games');
        const gameDivs = page.locator('.game');
        const gameCount = await gameDivs.count();
        expect(gameCount).toBeGreaterThanOrEqual(3);
    });

});

