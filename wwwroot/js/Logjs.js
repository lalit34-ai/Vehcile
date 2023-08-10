$(document).ready(function () {
    $('#show_password').click(function () {
        var passwordInput = $('#form2Example3');
        var passwordFieldType = passwordInput.attr('type');
        var showPasswordIcon = $('.fa-eye');

        if (passwordFieldType === 'password') {
            passwordInput.attr('type', 'text');
            showPasswordIcon.removeClass('fa-eye').addClass('fa-eye-slash');
        } else {
            passwordInput.attr('type', 'password');
            showPasswordIcon.removeClass('fa-eye-slash').addClass('fa-eye');
        }
    });
});
