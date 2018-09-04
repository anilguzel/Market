function ProductList() {
    $("#tblProduct").html("");

    $.getJSON("http://localhost:5454/api/Products", function (data) {
        $.each(data, function (i, item) {
            $("#tblProduct").append(
                "<tr><td>" + item.ProductId + "</td>" +
                "<td>" + item.ProductName + "</td>" +
                "<td>" + item.UnitInStock + "</td>" +
                "<td>" + item.Price + "</td>" +
                "<td>" + item.PriceVat + "</td>" +
                "<td>" + item.CategoryId + "</td>" +
                "<td><input type='submit' class='btn btn-primary' onclick='ProductFetch(\"" + item.ProductId + "\");' value='Update' /></td>" +
                "<td><input type='submit' class='btn btn-danger' onclick='ProductDelete(\"" + item.ProductId + "\");' value='Delete' /></td></tr>"
            );
        });
    });

}

function ProductAdd() {
    $.ajax({
        type: "POST",
        url: "http://localhost:5454/api/Products",
        data: $("#ProductAddForm").serialize(),
        success: function () {
            alert("Product Added");
        }
    });
}

function ProductFetch(id) {
    $.getJSON("http://localhost:5454/api/Products/" + id)
        .done(function (data) {
            $("#ProductUpdateForm #ProductId").val(data.ProductId);
            $("#ProductUpdateForm #ProductName").val(data.ProductName);
            $("#ProductUpdateForm #UnitInStock").val(data.UnitInStock);
            $("#ProductUpdateForm #Price").val(data.Price);
            $("#ProductUpdateForm #PriceVat").val(data.PriceVat);
            $("#ProductUpdateForm #CategoryId").val(data.CategoryId);


            $("#ProductUpdateForm #btnProductUpdate").attr("onclick", "ProductUpdate();");
        });
}

function ProductUpdate() {
    $.ajax({
        type: "PUT",
        url: "http://localhost:5454/api/Products",
        data: $("#ProductUpdateForm").serialize(),
        success: function () {
            alert("Product Updated");
        }
    });
}

function ProductDelete(id) {
    $.ajax({
        type: "DELETE",
        url: "http://localhost:5454/api/Products/" + id,
        success: function () {
            alert("Product Deleted");
        }
    });
}

$(document).ready(function() {

    $.ajax({
        url: "http://localhost:5454/api/categories",
        type: "get",
        success: function(data) {
            $.each(data,
                function(i) {
                    $('#CategoryId')
                        .append($('<option></option>').val(data[i].CategoryId).html(data[i].CategoryName));
                });
        },
        error: function(msg) { alert(msg); }
    });
}); 
