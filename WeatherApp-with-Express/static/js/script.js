document.body.classList.add('light');

// add event listeners:
document.getElementById('checkbox').addEventListener('click', toggleTheme);
document.getElementById('input').addEventListener('input', handleInputChange);
document.getElementById('inputForm').addEventListener('submit', handleSubmit);

function toggleTheme() {
  if (document.body.classList.contains('dark')) {
    document.body.classList.remove('dark');
    document.body.classList.add('light');
  } else if (document.body.classList.contains('light')) {
    document.body.classList.remove('light');
    document.body.classList.add('dark');
  }
}
