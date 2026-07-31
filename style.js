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