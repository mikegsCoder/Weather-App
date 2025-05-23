﻿// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.body.classList.add('light');

function toggleTheme() {
    if (document.body.classList.contains('dark')) {
        document.body.classList.remove('dark');
        document.body.classList.add('light');
    } else if (document.body.classList.contains('light')) {
        document.body.classList.remove('light');
        document.body.classList.add('dark');
    }
};

function displayLoader() {
    if (!input.value) return;
    clearBody();
    document.getElementById('loader').style.display = 'flex';
}

function onInputHandler() {
    clearBody();
}

function clearBody() {
    const weatherInfo = document.getElementById('weather-info');
    if (weatherInfo) weatherInfo.style.display = 'none';

    const notFound = document.getElementById('not-found');
    if (notFound) notFound.style.display = 'none';
}