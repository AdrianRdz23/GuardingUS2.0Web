var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Home/GetAll"
        },
        "columns": [
            { "data": "id", "width": "15%" },
            { "data": "number", "width": "15%" },
            { "data": "cars", "width": "15%" },
            { "data": "address", "width": "15%" },
            { "data": "applicationUser.name", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="w-75 btn-group" role = "group">
                        <a href="/Admin/Home/Upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i>Edit</a>
                        <a onClick=Delete('/Admin/Home/Delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash3-fill"></i> Delete</a>
                    </div>
                    `
                },
                "width": "15%"
            }
        ]
    });
}