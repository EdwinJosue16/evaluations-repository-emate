var modals = document.getElementsByClassName("modal");
var buttonsToShowModal = document.getElementsByClassName("show-modal btn-success");
var buttonsForCloseModal = document.getElementsByClassName("close-modal");

function openModal(modal, numero)
{
    modal.style.display = "block";
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }
}

function closeModal(modal) {
    modal.style.display = "none";
}

for (let i = 0; i < modals.length;++i) {
    buttonsToShowModal[i].addEventListener('click', function () { openModal(modals[i],i) });
}