function getAirTransportResultValue() {
    let resultBox = document.getElementsByClassName("result")[0];
    const functionalityType = document.getElementById("functionalityInput").value;
    const dateTimeInput = document.getElementsByClassName("dateInput")[0].value;
    const manufactureYear = dateTimeInput.slice(0, 4);
    const currentYear = new Date().getFullYear();
    const previousIncidents = document.getElementById("previousIncidentsInput");
    const securityEquipmenPossession = document.getElementById("securityEquipmenPossession");
    const technicalServicability = document.getElementById("technicalServicability");
    const traveledDistance = document.getElementById("traveledDistance").value;

    let years;
    if (manufactureYear !== "") {
        years = currentYear - manufactureYear;
    }

    let initialValue = 100;
    switch (functionalityType) {
        case "Търговски":
            initialValue -= 5;
            break;
        case "Военен":
            initialValue -= 20;
            break;
        case "Товарен":
            initialValue -= 10;
            break;
    }
    if (years >= 5 && years <= 10) {
        initialValue -= 10;
    }
    else if (years > 10 && years <= 15) {
        initialValue -= 15;
    }
    else if (years > 15) {
        initialValue -= 20;
    }

    if (previousIncidents.checked) {
        initialValue -= 5;
    }

    if (!technicalServicability.checked) {
        initialValue -= 20;
    }

    if (!securityEquipmenPossession.checked) {
        initialValue -= 15;
    }

    if (traveledDistance >= 100000 && traveledDistance < 200000) {
        initialValue -= 10;
    }
    else if (traveledDistance >= 200000) {
        initialValue -= 20;
    }

    resultBox.textContent = initialValue;
}

function getSeaTransportResultValue() {
    let resultBox = document.getElementsByClassName("result")[0];
    const functionalityType = document.getElementById("functionalityInput").value;
    const movabilityType = document.getElementById("typeOfMovability").value;
    const dateTimeInput = document.getElementsByClassName("dateInput")[0].value;
    const manufactureYear = dateTimeInput.slice(0, 4);
    const currentYear = new Date().getFullYear();
    const previousIncidents = document.getElementById("previousIncidentsInput");
    const securityEquipmenPossession = document.getElementById("securityEquipmenPossession");
    const technicalServicability = document.getElementById("technicalServicability");
    const traveledDistance = document.getElementById("traveledDistance").value;
    const doesRoutePassesPirateZones = document.getElementById("doesRoutePassesPirateZones");
    let years;
    if (manufactureYear !== "") {
        years = currentYear - manufactureYear;
    }

    let initialValue = 100;
    switch (functionalityType) {
        case "Търговски":
            initialValue -= 5;
            break;
        case "Военен":
            initialValue -= 15;
            break;
        case "Товарен":
            initialValue -= 10;
            break;
    }

    switch (movabilityType) {
        case "Ветроходен":
            initialValue -= 5;
            break;
        case "Моторен":
            initialValue -= 10;
            break;
    }
    if (years >= 5 && years <= 10) {
        initialValue -= 5;
    }
    else if (years > 10 && years <= 15) {
        initialValue -= 10;
    }
    else if (years > 15) {
        initialValue -= 15;
    }

    if (previousIncidents.checked) {
        initialValue -= 5;
    }

    if (!technicalServicability.checked) {
        initialValue -= 15;
    }

    if (!securityEquipmenPossession.checked) {
        initialValue -= 15;
    }

    if (doesRoutePassesPirateZones.checked) {
        initialValue -= 15;
    }

    if (traveledDistance >= 100000 && traveledDistance < 200000) {
        initialValue -= 5;
    }
    else if (traveledDistance >= 200000) {
        initialValue -= 10;
    }


    resultBox.textContent = initialValue;
}

function getLandTransportResultValue() {
    let resultBox = document.getElementsByClassName("result")[0];
    const fuelType = document.getElementById("fuelTypeInput").value;
    const mostCommonRoutes = document.getElementById("mostCommonRoutesInput").value;
    const dateTimeInput = document.getElementsByClassName("dateInput")[0].value;
    const manufactureYear = dateTimeInput.slice(0, 4);
    const currentYear = new Date().getFullYear();
    const previousIncidents = document.getElementById("previousIncidentsInput");
    const securityEquipmenPossession = document.getElementById("securityEquipmenPossession");
    const technicalServicability = document.getElementById("technicalServicability");
    const traveledDistance = document.getElementById("traveledDistance").value;
    const parktronic = document.getElementById("parktronicInput");
    let years;
    if (manufactureYear !== "") {
        years = currentYear - manufactureYear;
    }

    let initialValue = 100;
    
    if (years >= 5 && years <= 10) {
        initialValue -= 5;
    }
    else if (years > 10 && years <= 15) {
        initialValue -= 10;
    }
    else if (years > 15) {
        initialValue -= 15;
    }

    if (previousIncidents.checked) {
        initialValue -= 5;
    }

    if (!technicalServicability.checked) {
        initialValue -= 15;
    }

    if (!securityEquipmenPossession.checked) {
        initialValue -= 15;
    }    

    if (traveledDistance >= 100000 && traveledDistance < 200000) {
        initialValue -= 5;
    }
    else if (traveledDistance >= 200000) {
        initialValue -= 10;
    }

    if (!parktronic.checked) {
        initialValue -= 15;
    }

    switch (fuelType) {
        case "Бензин":
            initialValue -= 10;
            break;
        case "Дизел":
            initialValue -= 5;
            break;
        case "Бензин + пропан":
            initialValue -= 15;
            break;
        case "Електричество":
            initialValue -= 5;
            break;
    }

    switch (mostCommonRoutes) {
        case "Градски":
            initialValue -= 10;
            break;
        case "Междуградски":
            initialValue -= 5;
            break;
    }

    resultBox.textContent = initialValue;
}

function getBusinessResultValue() {
    let resultBox = document.getElementsByClassName("result")[0];
    const previousIncidents = document.getElementById("previousIncidentsInput");
    const fireExtinguishers = document.getElementById("fireExtinguishersInput");
    const emergencyExit = document.getElementById("emergencyExitInput");
    const gasBottles = document.getElementById("gasBottlesInput");
    const alarmSystem = document.getElementById("alarmSystemInput");
    const purposeOfTheEnterprise = document.getElementById("purposeOfEnterpriseInput").value;
    let initialValue = 100;

    if (previousIncidents.checked) {
        initialValue -= 5;
    }
    if (!fireExtinguishers.checked) {
        initialValue -= 25;
    }
    if (!emergencyExit.checked) {
        initialValue -= 30;
    }
    if (!alarmSystem.checked) {
        initialValue -= 10;
    }
    if (gasBottles.checked) {
        initialValue -= 20;
    }
    switch (purposeOfTheEnterprise) {
        case "Производствена дейност":
            initialValue -= 10;
            break;
        case "Преработваща дейност":
            initialValue -= 10;
            break;
    }

    resultBox.textContent = initialValue;
}

function getVillaAndCommercialResultValue() {
    let resultBox = document.getElementsByClassName("result")[0];
    const previousIncidents = document.getElementById("previousIncidentsInput");
    const fireExtinguishers = document.getElementById("fireExtinguishersInput");
    const emergencyExit = document.getElementById("emergencyExitInput");
    const gasBottles = document.getElementById("gasBottlesInput");
    const alarmSystem = document.getElementById("alarmSystemInput");
    let initialValue = 100;

    if (previousIncidents.checked) {
        initialValue -= 5;
    }
    if (!fireExtinguishers.checked) {
        initialValue -= 25;
    }
    if (!emergencyExit.checked) {
        initialValue -= 35;
    }
    if (!alarmSystem.checked) {
        initialValue -= 15;
    }
    if (gasBottles.checked) {
        initialValue -= 20;
    }

    resultBox.textContent = initialValue;
}

function getResidentialResultValue() {
    let resultBox = document.getElementsByClassName("result")[0];
    const previousIncidents = document.getElementById("previousIncidentsInput");
    const fireExtinguishers = document.getElementById("fireExtinguishersInput");
    const emergencyExit = document.getElementById("emergencyExitInput");
    const gasBottles = document.getElementById("gasBottlesInput");
    const alarmSystem = document.getElementById("alarmSystemInput");
    const floorType = document.getElementById("floorTypeInput").value;
    let initialValue = 100;

    if (previousIncidents.checked) {
        initialValue -= 5;
    }
    if (!fireExtinguishers.checked) {
        initialValue -= 25;
    }
    if (!emergencyExit.checked) {
        initialValue -= 35;
    }
    if (!alarmSystem.checked) {
        initialValue -= 10;
    }
    if (gasBottles.checked) {
        initialValue -= 20;
    }
    switch (floorType) {
        case "Последен":
            initialValue -= 5;
            break;
        case "Първи":
            initialValue -= 5;
            break;
    }

    resultBox.textContent = initialValue;
}