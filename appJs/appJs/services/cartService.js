myApp.factory('cartService', function () {


    var cartItems = JSON.parse(localStorage.getItem('cartItems'));
    if (!cartItems || !Array.isArray(cartItems)) {
        cartItems = [];
    }

    function saveCartItems() {
        localStorage.setItem('cartItems', JSON.stringify(cartItems));
    }

    return {
        getCartItems: function () {
            return cartItems;
        },
        addToCart: function (game) {
            var existingItem = cartItems.find((item) => item.GameId === game.GameId);
            if (existingItem) {
                existingItem.quantity++;
            } else {
                var newItem = {
                    GameId: game.GameId,
                    quantity: 1,
                    Title: game.Title,
                    Price: game.Price,
                    Image: game.Image,
                    ESBR: game.ESBR
                };
                cartItems.push(newItem);
            }
            saveCartItems();
        },
        clearCart: function () {
            cartItems = [];
            saveCartItems();
        },
        saveCartItemsToLocalStorage: function (cartItems) {
            localStorage.setItem('cartItems', JSON.stringify(cartItems));
        },
        removeFromCart: function (gameId) {
            var item = cartItems.find((item) => item.GameId === gameId);
            if (item) {
                item.quantity--;
                if (item.quantity <= 0) {
                    var indexToRemove = cartItems.indexOf(item);
                    if (indexToRemove !== -1) {
                        cartItems.splice(indexToRemove, 1);
                    }
                }
                saveCartItems();
            }
        },
        removeAllFromCart: function (gameId) {
            var indexToRemove = cartItems.findIndex((item) => item.GameId === gameId);
            if (indexToRemove !== -1) {
                cartItems.splice(indexToRemove, 1);
                saveCartItems();
            }
        }
    };
});
