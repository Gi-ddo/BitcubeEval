
var modal = document.getElementById('modalRef');
var modalBtn = document.getElementsByClassName('modalBtn');

for (var i = 0; i < modalBtn.length; i++) {
    
    modalBtn[i].addEventListener('click', openModal);
}

var closeBtn = document.getElementById('closeBtnRef');


closeBtn.addEventListener('click', closeModal);
window.addEventListener('click', windowClick);

function openModal() {

    modal.style.display = 'block';
}

function closeModal() {

    modal.style.display = 'none';
}

function windowClick(e) {
    if (e.target == modal) {
        modal.style.display = 'none';
    }
}