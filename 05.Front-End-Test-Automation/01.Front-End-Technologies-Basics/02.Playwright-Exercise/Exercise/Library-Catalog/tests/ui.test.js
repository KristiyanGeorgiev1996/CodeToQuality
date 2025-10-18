const { test, expect } = require('@playwright/test')
// import { test, expect } from '@playwright/test' ES6 syntax
// "type": "module", need to be added in package.json for ES6 syntax


const url = 'http://localhost:3000'

test('Verify "All Books" link is visible', async ({ page }) => {
    await page.goto(url)
    await page.waitForSelector('nav.navbar')

    const allBooksLink = await page.$('a[href="/catalog"]')
    const isLinkVisible = await allBooksLink.isVisible()
    expect(isLinkVisible).toBe(true)
})

test('Verify That the "Login" Button Is Visible', async ({ page }) => {
    await page.goto(url)
    await page.waitForSelector('nav.navbar')

    const loginButton = await page.$('a[href="/login"]')
    const isLoginButtonVIsible = await loginButton.isVisible()
    expect(isLoginButtonVIsible).toBe(true)
})

test('Verify That the "Register" Button Is Visible', async ({ page }) => {
    await page.goto(url)
    await page.waitForSelector('nav.navbar')

    const registerButton = await page.$('a[href="/register"]')
    const isRegisterButtonVIsible = await registerButton.isVisible()
    expect(isRegisterButtonVIsible).toBe(true)
})

test('Verify "All Books" link is visible after user login', async ({ page }) => {
    await page.goto(`${url}/login`)

    await page.fill('#email', 'peter@abv.bg')
    await page.fill('#password', '123456')
    await page.click('input[value="Login"]')

    const allBooksLink = await page.$('a[href="/catalog"]')
    const isLinkVisible = await allBooksLink.isVisible()
    expect(isLinkVisible).toBe(true)

})

test('Login with valid credentials', async ({ page }) => {
    await page.goto(`${url}/login`)

    await page.fill('#email', 'peter@abv.bg')
    await page.fill('#password', '123456')
    await page.click('input[value="Login"]')

    await page.$('a[href="/catalog"]')
    const pageURL = page.url()
    expect(pageURL).toBe(`${url}/catalog`)

})

test('Login with empty input fields', async ({ page }) => {
    await page.goto(`${url}/login`)

    await page.click('input[value="Login"]')

    page.on('dialog', async dialog => {
        expect(dialog.type().toContain('alert'))
        expect(dialog.message().toContain('All fields are required!'))
        await dialog.accept()
    })

    await page.$('a[href="/login"]')
    const pageURL = page.url()
    expect(pageURL).toBe(`${url}/login`)

})

test('Add book with correct data', async ({ page }) => {
    await page.goto(`${url}/login`)

    await page.fill('#email', 'peter@abv.bg')
    await page.fill('#password', '123456')

    await Promise.all([
        await page.click('input[value="Login"]'),
        page.waitForURL(`${url}/catalog`)
    ])
    await page.click('a[href="/create"]')
    await page.waitForSelector('#create-page')

    await page.fill('#title', 'Test Book')
    await page.fill('#description', 'Test description')
    await page.fill('#image', 'example url')
    await page.selectOption('#type', 'Fiction')

    await page.click('input[value="Add Book"]')

    await page.waitForURL(`${url}/catalog`)

    const pageURL = page.url()
    expect(pageURL).toBe(`${url}/catalog`)

})

test('Add book with empty title field', async ({ page }) => {
    await page.goto(`${url}/login`)

    await page.fill('#email', 'peter@abv.bg')
    await page.fill('#password', '123456')

    await Promise.all([
        await page.click('input[value="Login"]'),
        page.waitForURL(`${url}/catalog`)
    ])
    await page.click('a[href="/create"]')
    await page.waitForSelector('#create-page')


    await page.fill('#description', 'Test description')
    await page.fill('#image', 'example url')
    await page.selectOption('#type', 'Fiction')

    await page.click('input[value="Add Book"]')

    page.on('dialog', async dialog => {
        expect(dialog.type().toContain('alert'))
        expect(dialog.message().toContain('All fields are required!'))
        await dialog.accept()
    })

    await page.$('a[href="create"]')

    const pageURL = page.url()
    expect(pageURL).toBe(`${url}/create`)

})

test('Verify all books are displayed after login', async ({ page }) => {
    await page.goto(`${url}/login`)
    // to check
    await page.fill('#email','peter@abv.bg')
    await page.fill('#password','123456')

    await Promise.all([
        page.click('input[type="submit"]'),
        page.waitForURL(`${url}/catalog`)
    ])

    await page.waitForSelector('.dashboard')

    const bookElements = await page.$$('.other-books-list li.otherBooks')

    expect(bookElements.length).toBeGreaterThan(0)

})

test('Login and navigate to Details page', async ({ page }) => {
    await page.goto(`${url}/login`)
    await page.fill('#email','peter@abv.bg')
    await page.fill('#password','123456')

    await Promise.all([
        page.click('input[type="submit"]'),
        page.waitForURL(`${url}/catalog`)
    ])

    await page.waitForSelector('.otherBooks')
    await page.click('.otherBooks a.button')

    await page.waitForSelector('.book-information')
    const detailsPageTitle = await page.textContent('.book-information h3')
    expect(detailsPageTitle).toBe('Test Book')

})
