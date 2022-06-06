const uri = 'api/ComicConTickets';
let tickets = [];

function getTickets() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

function addTicket() {
    const addTicketTextbox = document.getElementById('add-ticket');
    const addDateValidTextbox = document.getElementById('add-datesValid');
    const addPriceOfTicketTextbox = document.getElementById('add-priceOfTicket');

    const aTicket = {
        isRefundable: false,
        typeOfTicket: addTicketTextbox.value.trim(),
        datesValidFor: addDateValidTextbox.value.trim(),
        priceOfTicket: addPriceOfTicketTextbox.value.trim()
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(aTicket)
    })
        .then(response => response.json())
        .then(() => {
            getTickets();
            addTicketTextbox.value = '';
            addDateValidTextbox.value = '';
            addPriceOfTicketTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}

function deleteTicket(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getTickets())
        .catch(error => console.error('Unable to delete item.', error));
}

function displayEditForm(id) {
    const aTicket = tickets.find(aTicket => aTicket.id === id);

    document.getElementById('edit-typeOfTicket').value = aTicket.typeOfTicket;
    document.getElementById('edit-datesValid').value = aTicket.datesValidFor;
    document.getElementById('edit-priceOfTicket').value = aTicket.priceOfTicket;
    document.getElementById('edit-id').value = aTicket.id;
    document.getElementById('edit-isRefundable').checked = aTicket.isRefundable;
    document.getElementById('editForm').style.display = 'block';
}

function updateTicket() {
    const ticketId = document.getElementById('edit-id').value;
    const aTicket = {
        id: parseInt(ticketId, 10),
        isRefundable: document.getElementById('edit-isRefundable').checked,
        typeOfTicket: document.getElementById('edit-typeOfTicket').value.trim(),
        datesValidFor: document.getElementById('edit-datesValid').value.trim(),
        priceOfTicket: document.getElementById('edit-priceOfTicket').value.trim()
    };

    fetch(`${uri}/${ticketId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(aTicket)
    })
        .then(() => getTickets())
        .catch(error => console.error('Unable to update item.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
    const name = (itemCount === 1) ? 'Ticket' : 'Tickets';

    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

function _displayItems(data) {
    const tBody = document.getElementById('tickets');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(aTicket => {
        let isRefundableCheckbox = document.createElement('input');
        isRefundableCheckbox.type = 'checkbox';
        isRefundableCheckbox.disabled = true;
        isRefundableCheckbox.checked = aTicket.isRefundable;

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${aTicket.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteTicket(${aTicket.id})`);

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        td1.appendChild(isRefundableCheckbox);

        let td2 = tr.insertCell(1);
        let textNode = document.createTextNode(aTicket.typeOfTicket);
        td2.appendChild(textNode);

        let td3 = tr.insertCell(2);
        let textNode2 = document.createTextNode(aTicket.datesValidFor);
        td3.appendChild(textNode2);

        let td4 = tr.insertCell(3);
        let textNode3 = document.createTextNode(aTicket.priceOfTicket);
        td4.appendChild(textNode3);

        let td5 = tr.insertCell(4);
        td5.appendChild(editButton);

        let td6 = tr.insertCell(5);
        td6.appendChild(deleteButton);
    });

    tickets = data;
}