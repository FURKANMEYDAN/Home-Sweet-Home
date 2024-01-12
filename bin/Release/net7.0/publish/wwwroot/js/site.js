function geriDon() {
    var btn = document.getElementById("logo");
    var tiklandi = false;
    btn.addEventListener("click", function () {
        tiklandi = true;
    });
    if (tiklandi = true) {
        window.location = "/home";
    }

}function addToCart(imageSrc, description) {
    var cartItems = document.getElementById('cartItems');
    
    var cartItem = document.createElement('div');
    cartItem.classList.add('cart-item');
  
    var image = document.createElement('img');
    image.src = imageSrc; 
    image.alt = description;
  
    var text = document.createElement('p');
    text.textContent = description;
  
    cartItem.appendChild(image);
    cartItem.appendChild(text);
    cartItems.appendChild(cartItem);
    
   
    toggleCart();
  }
  function clearCart() {
    var cartItems = document.getElementById('cartItems');
    cartItems.innerHTML = ''; 
}
  
  document.getElementById('fileInput').addEventListener('change', function(event) {
    var file = event.target.files[0];
    if (file) {
      var reader = new FileReader();
      reader.onload = function(e) {
        var imgSrc = e.target.result;
        var description = 'Uploaded Image'; 
        addToCart(imgSrc, description);
      };
      reader.readAsDataURL(file);
    }
  });
  
function toggleCart() {
    var cartPopup = document.getElementById("cartPopup");
    var mainContent = document.querySelector(".main-content");

    if (cartPopup.style.right === "-300px" || cartPopup.style.right === '') {
        cartPopup.style.right = "0";
        mainContent.classList.add("blur");
        attachCloseEventListener();
    } else {
        closeCart();
    }
}

function closeCart() {
    var cartPopup = document.getElementById("cartPopup");
    var mainContent = document.querySelector(".main-content");

    cartPopup.style.right = "-300px";
    mainContent.classList.remove("blur");
    removeCloseEventListener();
}

function handleCloseClick() {
    closeCart();
}

function attachCloseEventListener() {
    var closeCartBtn = document.getElementById('closeCart');
    closeCartBtn.addEventListener('click', handleCloseClick);
}

function removeCloseEventListener() {
    var closeCartBtn = document.getElementById('closeCart');
    closeCartBtn.removeEventListener('click', handleCloseClick);
}

document.addEventListener('DOMContentLoaded', function () {
    var cartButton = document.getElementById('cartButton');
    cartButton.addEventListener('click', toggleCart);
});

document.getElementById('searchInput').addEventListener('input', function() {
    var searchValue = this.value.toLowerCase();
    var imageContainers = document.querySelectorAll('.image-container');
  
    imageContainers.forEach(function(container) {
      var description = container.querySelector('img').getAttribute('data-description').toLowerCase();
      if (description.includes(searchValue)) {
        container.style.display = 'block';
      } else {
        container.style.display = 'none';
      }
    });
  });
  

  var filterButtons = document.querySelectorAll('.filter-btn');
  
  filterButtons.forEach(function(button) {
    button.addEventListener('click', function() {
      var filterValue = this.getAttribute('data-filter');
      var imageContainers = document.querySelectorAll('.image-container');
  
      imageContainers.forEach(function(container) {
        var category = container.getAttribute('data-category');
        if (filterValue === 'all' || category === filterValue) {
          container.style.display = 'block';
        } else {
          container.style.display = 'none';
        }
      });
    });
  });

 


