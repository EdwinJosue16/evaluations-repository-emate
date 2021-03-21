var modals = document.getElementsByClassName("modal");
var buttonsToShowModal = document.getElementsByClassName("show-modal btn-success");
var buttonsToCloseModal = document.getElementsByClassName("close");

function openModal(modal)
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
    buttonsToShowModal[i].addEventListener('click', function () { openModal(modals[i]) });
    buttonsToCloseModal[i].addEventListener('click', function () { closeModal(modals[i]) });
}