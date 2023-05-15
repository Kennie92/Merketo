var elements = document.querySelectorAll('[data-val="true"]')
for (let element of elements) {
    element.addEventListener("keyup", function (e) {
        switch (e.target.type) {
            case 'text':
                textValidator(e.target, 2)
                break;

           case 'password':
             passwordValidator(e.target);
               break;
        }
    })
}

function textValidator(target, minLength) {
    if (target.value.length < minLength)
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} is invalid`
          else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""

}


function passwordValidator(target) {
    const regEx = /^(?=.*[a-ö])(?=.*[A-Ö])(?=.*\d)(?=.*[!@#$^&*])[A-Öa-ö\d!@#$%^&*]{8,}$/;
    if (!regEx.test(target.value))
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} is invalid`
        else 
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""


}

