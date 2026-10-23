// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const searchInput = document.getElementById("searchInput");

if (searchInput) {
    searchInput.addEventListener("keyup", function () {

        const keyword = this.value.toLowerCase();

        const products = document.querySelectorAll(".products-item");

        products.forEach(function (product) {

            const productName = product.querySelector(".product-name")
                .textContent
                .toLowerCase();

            if (productName.includes(keyword)) {
                product.style.display = "";
            } else {
                product.style.display = "none";
            }

        });

    });
}