function getFileName(e) {
    var fileName = e.target.files[0].name;
    document.getElementById('fileName').innerHTML = fileName;
}

function validateRequired(e) {


    validationfield = document.querySelector(`[data-valmsg-for="${e.target.id}" ]`)

    if (e.target.value.length >= 1)
        validationfield.innerHTML = ""
    else
        validationfield.innerHTML = e.target.dataset.valRequired
}




const toggleMenuBtn = (attribute) => {
    const btn = document.querySelector(attribute)

    btn.addEventListener('click', function () {
        const element = document.querySelector(btn.getAttribute('data-target'))
        const contains = element.classList.contains('open-menu')

        element.classList.toggle('open-menu', !contains)
        btn.classList.toggle('btn-outline-dark', !contains)
        btn.classList.toggle('btn-toggle-white', !contains)


    })
}




const toggleClassName = (element, className, expression) => {
    document.querySelector(element).classList.toggle(className, expression)
}






