var elements = document.querySelectorAll('[data-val="true"]')
for (let element of elements) {
    element.addEventListener("keyup", function (e) {
        switch (e.target.type) {
            

           case 'password':
             passwordValidator(e.target);
                break;

            case 'email':
                emailValidator(e.target);
                break;

            case 'textarea':
                messageValidator(e.target, 4);
                break;

         

            case 'checkbox':
                checkboxValidator(e.target, true);
                break;
        }
    })
}




function passwordValidator(target) {
    const regEx = /^(?=.*[a-ö])(?=.*[A-Ö])(?=.*\d)(?=.*[!@#$^&*])[A-Öa-ö\d!@#$%^&*]{8,}$/;
    if (!regEx.test(target.value))
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} Password must cotain atleast eight characters, one special character and one uppercase letter`
        else 
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""
}

function emailValidator(target) {
    const regEx = /^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$/;
    validationfield = document.querySelector(`[data-valmsg-for= "${target.id}"]`)
    if (!regEx.test(target.value))
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} is invalid, example: John@domain.com`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""
}


function messageValidator(target, minLength) {
    if (target.value.length < minLength)
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} must contain atleast four characters`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""

}



function checkboxValidator(target) {
    if (target.checked === true)
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""
    else

        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `You must agree to the terms and conditions`

}






var elements = document.querySelectorAll('[type="number"]')
for (let element of elements) {
    element.addEventListener("keyup", function (e) {
        switch (e.target.id) {

            case 'Price':
                priceValidator(e.target, 1);
                break;

            case 'PostalCode':
                postalCodeValidator(e.target, 5);
                break;

        }
    })
}

function priceValidator(target, minLength) {
    if (target.value.length < minLength)
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} needs to contain atleast one digit.`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""

}


function postalCodeValidator(target, minLength) {
    if (target.value.length < minLength)
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} needs to contain atleast five digit.`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""

}




var elements = document.querySelectorAll('[type="text"]')
for (let element of elements) {
    element.addEventListener("keyup", function (e) {
        switch (e.target.id) {

            case 'FirstName':
                firstNameValidator(e.target, 2);
                break;

            case 'LastName':
                lastNameValidator(e.target, 2);
                break;

            case 'StreetName':
                streetNameValidator(e.target, 4);
                break


            case 'ArticleNumber':
                articleNumberValidator(e.target);
                break;

            case 'ProductName':
                productNameValidator(e.target, 3);
                break;

            case 'ImageUrl':
                urlValidator(e.target, 3);
                break;
        }
    })
}


function firstNameValidator(target, minLength) {
    if (target.value.length < minLength)
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} must contain atleast two characters.`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""

}


function lastNameValidator(target, minLength) {
    if (target.value.length < minLength)
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} must contain atleast two characters.`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""

}

function streetNameValidator(target, minLength) {
    if (target.value.length < minLength)
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} must contain atleast four characters.`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""

}


function articleNumberValidator(target) {
    const regEx = /^[A-Za-z]{4,}-\d{4,}$/;
    validationfield = document.querySelector(`[data-valmsg-for= "${target.id}"]`)
    if (!regEx.test(target.value))
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} is invalid, example: DOGS-0001`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""
}


function productNameValidator(target, minLength) {
    if (target.value.length < minLength)
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} must contain atleast three characters.`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""

}

function urlValidator(target) {
    const regEx = /^(http(s):\/\/.)[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)$/;
    validationfield = document.querySelector(`[data-valmsg-for= "${target.id}"]`)
    if (!regEx.test(target.value))
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} is invalid, example: https://domain.com`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""
}