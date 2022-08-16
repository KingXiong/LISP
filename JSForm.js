function formValidation(event) {
    event.preventDefault();

    let firstName = document.getElementById("firstName").value;
    let lastName = document.getElementById("lastName").value;
    let npiNumber = document.getElementById("npiNumber").value;
    let address = document.getElementById("address").value;
    let phoneNumber = document.getElementById("phoneNumber").value;
    let email = document.getElementById("email").value;


    if (firstNameCheck(firstName) && lastNameCheck(lastName) && npiNumberCheck(npiNumber) && addressCheck(address) && phoneNumberCheck(phoneNumber) && emailCheck(email)) {
        document.getElementById("avaHeader").style.display = "none";
        document.getElementById("thx").removeAttribute('hidden');
    }
}

function firstNameCheck(firstName) {
    var regExpName = /^[a-zA-Z]+$/;
    if (!regExpName.test(firstName.value)) {
        return false;
    } else {
        return true;
    }
}

function lastNameCheck(lastName) {
    var regExpName = /^[a-zA-Z]+$/;
    if (!regExpName.test(lastName.value)) {
        return false;
    } else {
        return true;
    }
}

function npiNumberCheck(npiNumber) {
    let parseNPI = npiNumber.length;

    if (npiNumber === NaN) {
        return false;
    }
    if (parseNPI !== 10) {
        return false;
    } else {
        return true;
    }
}

function addressCheck(address) {
    if (address.value === "") {
        return false;
    } else {
        return true;
    }
}

function phoneNumberCheck(phoneNumber) {
    let regExpPhoneNumber = /^\(?(\d{3})\)?[- ]?(\d{3})[- ]?(\d{4})$/

    if (!regExpPhoneNumber.test(phoneNumber)) {
        return false;
    } else {
        return true;
    }
}

function validatePhoneNumber(input_str) {
    var re = /^\(?(\d{3})\)?[- ]?(\d{3})[- ]?(\d{4})$/;

    return re.test(input_str);
}

function emailCheck(email) {
    let regEXPEmail = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if (!regEXPEmail.test(email)) {
        return false;
    } else {
        return true;
    }
}
