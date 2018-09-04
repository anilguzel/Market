function CategoryList() {
    $("#tblCategory").html(""); 

    $.getJSON("http://localhost:5454/api/Categories", function (data) {
        $.each(data, function (i, item) {
            $("#tblCategory").append( 
                "<tr><td>" + item.CategoryId + "</td>" +
                "<td>" + item.CategoryName + "</td>" +
                "<td>" + item.IsActive + "</td>" +
                "<td>" + item.Order + "</td>" +
                "<td><input type='submit' class='btn btn-primary' onclick='CategoryFetch(\"" + item.CategoryId + "\");' value='Update' /></td>" +
                "<td><input type='submit' class='btn btn-danger' onclick='CategoryDelete(\"" + item.CategoryId + "\");' value='Delete' /></td></tr>" 
            );
        });
    })

}

function CategoryAdd() {
    $.ajax({
        type: "POST",
        url: "http://localhost:5454/api/Categories",
        data: $("#CategoryAddForm").serialize(),
        success: function () {
            alert("Category Added");
        }
    });
}

function CategoryFetch(id) {
    $.getJSON("http://localhost:5454/api/Categories/" + id)
        .done(function(data) {
            $("#CategoryUpdateForm #CategoryId").val(data.CategoryId);
            $("#CategoryUpdateForm #CategoryName").val(data.CategoryName);
            $("#CategoryUpdateForm #IsActive").val(data.IsActive);
            $("#CategoryUpdateForm #Order").val(data.Order);

            $("#CategoryUpdateForm #btnCategoryUpdate").attr("onclick", "CategoryUpdate();");
        });
}

function CategoryUpdate() {
    $.ajax({
        type: "PUT",
        url: "http://localhost:5454/api/Categories",
        data: $("#CategoryUpdateForm").serialize(),
        success: function() {
            alert("Category Updated");
        }
    });
}

function CategoryDelete(id) {
    $.ajax({
        type: "DELETE",
        url: "http://localhost:5454/api/Categories1/" + id,
        success: function() {
            alert("Category Deleted");
        }
    });
}