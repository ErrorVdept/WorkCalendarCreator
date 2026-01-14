window.getBrowserCulture = () => {
    return navigator.language || navigator.userLanguage || 'en-US';
};