$(document).on("click", "#loadMoreBtn", function () {
    $.ajax({
        url: "/Courses/LoadMore",
        type:"GET", 
        success: function (response) {
            $("#myCourses").append(response)
        }
    });
}); 