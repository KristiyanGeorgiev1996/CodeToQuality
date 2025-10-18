const { test, expect } = require('@playwright/test');

test('user can add a task', async ({ page }) => {
  await page.goto('http://localhost:8081/');
  await page.fill('#task-input', 'Test Task');
  await page.click('#add-task');
  const taskText = await page.textContent('.task');
  expect(taskText).toContain('Test Task');
});

test('user can delete a task', async ({ page }) => {
  await page.goto('http://localhost:8081/');
  await page.fill('#task-input', 'Test Task');
  await page.click('#add-task');
  await page.click('.task .delete-task');
  const tasks = await page.$$eval('.task', tasks => tasks.map(task => task.textContent));
  expect(tasks).not.toContain('Test Task');
});


test('user can mark task as completed', async ({ page }) => {
  await page.goto('http://localhost:8081/');
  await page.fill('#task-input', 'Test Task');
  await page.click('#add-task');
  await page.click('.task .task-complete');
  const completedTask = await page.$('.task.completed');
  expect(completedTask).not.toBeNull();
});

test('user can filter task', async ({ page }) => {
  await page.goto('http://localhost:8081/');
  await page.fill('#task-input', 'Test Task');
  await page.click('#add-task');
  await page.click('.task .task-complete');
  await page.selectOption('#filter', 'Completed');
  const incompleteTask = await page.$('task:not(completed)');
  expect(incompleteTask).toBeNull();
});
