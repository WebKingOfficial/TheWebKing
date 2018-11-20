const changePage = function (e) {
    const register = document.getElementById('register');
    const login = document.getElementById('login');
    const forgot = document.getElementById('forgot-password');
    if (e === 'forgot-password') {
        forgot.classList.contains('card-hidden') ?
            forgot.classList.remove('card-hidden') : forgot.classList.add('card-hidden');
        login.classList.contains('card-hidden') ?
            login.classList.remove('card-hidden') : login.classList.add('card-hidden');
    }
    else if (e === 'register') {
        register.classList.contains('card-hidden') ?
            register.classList.remove('card-hidden') : register.classList.add('card-hidden');
        login.classList.contains('card-hidden') ?
            login.classList.remove('card-hidden') : login.classList.add('card-hidden');
    }
}

$('.toggle').on('click', function () {
    $('.container').stop().addClass('active');
});

$('.close').on('click', function () {
    $('.container').stop().removeClass('active');
});