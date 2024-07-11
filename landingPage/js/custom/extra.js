/* Main navbar değerini nCollapsible adlı sabite çektik. 
Yoksa return et.
if scroll da oynama yoksa navbar-mobile'ı kaldır.
Else scroll da oynama varsa navbar-mobile 'ı çalıştır.
Mobil de zaten backgorund rengimiz sabit olduğu için bir sorun olmuyor.
Normal ekranda scroll aşağı indiğinde arkaplan vereceğiz.
*/
window.addEventListener("DOMContentLoaded", event => {
    var navbarMobile = function () {
        const nCollapsible = document.body.querySelector("#mainNavbar");
        if (!nCollapsible) {
            return;
        } if (window.scrollY === 0) {
            nCollapsible.classList.remove("navbar-mobile");
        } if (window.scrollY > 150) {
            nCollapsible.classList.add("navbar-mobile");
        }
        if (window.scrollY <= 150) {
            nCollapsible.classList.remove("navbar-mobile");
        }
    };
    navbarMobile();
    document.addEventListener("scroll", navbarMobile);
    const myNavbar = document.body.querySelector("#mainNavbar");
    if (myNavbar) {
        new bootstrap.ScrollSpy(document.body, {
            target: "#mainNavbar",
            offset: 74
        })
    }
});
var BtnCanvas = document.querySelectorAll(".btn-close-canvas");
for (let i = 0; i < BtnCanvas.length; i++) {
    BtnCanvas[i].addEventListener("click", function () {
        document.querySelector('[data-bs-dismiss="offcanvas"]').click();
    });
}

(function () {
    'use strict'
    var myName = document.querySelector("#name");
    var myEmail = document.querySelector("#email");
    var myPhone = document.querySelector("#phone");
    var myMessage = document.querySelector("#message");
    var myBtn = document.querySelector("#BtnContact");

    if (myMessage.value.length == 0) {
        myBtn.disabled = true;
    }

    /* Mesaj yazmak için kaç karakter hakkımız kaldığı bilgisini veriyor */
    myMessage.addEventListener("keyup", function () {
        document.getElementById("current-character").textContent = myMessage.value.length;
        if (myMessage.value.length >= 10) {
            myBtn.disabled = false;
        } else {
            myBtn.disabled = true;
        }
    });
    var myForms = document.querySelector(".needs-validation");
    myForms.addEventListener("sumbit", function (e) {
        if (!myForms.checkValidity()) {
            e.preventDefault();
            e.stopPropagation();
        }
    }, false);
})();
