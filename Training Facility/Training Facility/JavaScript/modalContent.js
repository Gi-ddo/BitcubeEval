var modal = document.getElementById('modalRef');

var modalBtn = document.getElementById('modalBtnRef');

var closeBtn = document.getElementById('closeBtnRef');

modalBtn.addEventListener('click', openModal);
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