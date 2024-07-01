
console.log("helooooo");

// Đăng nhập và đăng ký
document.addEventListener("DOMContentLoaded", function () {
    var loginLink = document.getElementById('login');
    var registerLink = document.getElementById('register');
    var loginModal = document.getElementById('loginModal');
    var registerModal = document.getElementById('registerModal');
    //var logoutLink = document.getElementById('logout');

    loginLink.addEventListener('click', function () {
        registerModal.style.display = 'none';
        loginModal.style.display = 'block';
        console.log("login");

    });

    var loginCloseButton = document.querySelector('#loginModal .close');
    loginCloseButton.addEventListener('click', function () {
        console.log("close");
        loginModal.style.display = 'none';
    });

    registerLink.addEventListener('click', function () {
        loginModal.style.display = 'none';
        registerModal.style.display = 'block';
        console.log("dangki");

    });

    var registerCloseButton = document.querySelector('#registerModal .close');
    registerCloseButton.addEventListener('click', function () {
        registerModal.style.display = 'none';
    });
    //logoutLink.addEventListener('click', function () {
    //    console.log("đăng xuất");
    //});

    //var registerNewAccountLink = document.querySelector('#loginModal .body-no-have-account a');
    //registerNewAccountLink.addEventListener('click', function (event) {
    //    event.preventDefault(); // Ngăn chặn hành vi mặc định của liên kết
    //    loginModal.style.display = 'none';
    //    registerModal.style.display = 'block';
    //});


    //logout

});
//document.getElementById('logout').addEventListener('click', function (e) {
//    console.log("logout");
//    //e.preventDefault(); // Ngăn chặn hành động mặc định của thẻ <a>
//    //// Gửi yêu cầu đến máy chủ để xử lý đăng xuất
//    //var xhr = new XMLHttpRequest();
//    //xhr.open('GET', 'Logout.aspx', true);
//    //xhr.onload = function () {
//    //    if (xhr.status === 200) {
//    //        // Đăng xuất thành công, có thể thực hiện các thao tác khác sau khi đăng xuất
//    //        alert('Đã đăng xuất thành công.');
//    //        // Redirect to another page if needed
//    //        window.location.href = 'Default.aspx'; // Change 'Default.aspx' to your desired redirect page
//    //    } else {
//    //        // Xử lý lỗi nếu cần
//    //        alert('Đã xảy ra lỗi khi đăng xuất.');
//    //    }
//    //};
//    //xhr.send();
//});
