$(document).ready(function() {
    $('.student-card').draggable({ stack: '.summoner-card' });
    $('.coach-card').droppable({
        drop: function(event, ui) {
            if ($(ui.draggable).hasClass('student-card')) {
                $(ui.draggable).hide();

                $(this).find('.coach-team').show();

                $(this).find('.coach-team ul').append(
                    '<li>' +
                    '<div class="student-signup-id" hidden="hidden">' +
                    $(ui.draggable).find('.student-signup-id').text() + '</div>' +
                    '<span class="small-icon"><img src="' +
                    $(ui.draggable).find('.rank-icon img').attr('src') + '"/></span>' +
                    $(ui.draggable).find('.summoner-name').text() +
                    '<span class="small-icon"><img src="' + $(ui.draggable).find('.position-icon img').attr('src') + '"/></span>' +
                    '<span class="float-right remove-link"><a href="#">Remove</a></span>' +
                    '</li>'
                );

                $.ajax({
                    type: 'POST',
                    url: '/Teams/AddStudentToCoachAsync',
                    data: JSON.stringify({
                        coachSignUpId: parseInt($(this).find('.coach-signup-id').text()),
                        studentSignUpId: parseInt($(ui.draggable).find('.student-signup-id').text())
                    }),
                    contentType: 'application/json; charset=utf8',
                    dataType: 'text',
                    success: function (data) {
                        if (data === 'true') {
                            console.log("Success");
                        } else {
                            console.log("An error occurred");
                        }
                    }
                });
            }
        }
    });

    $('.coach-team').on('click', '.remove-link', function() {
        var student = $(this).parent().find('.student-signup-id').text();
        var coach = $(this).parents('.card-container').find('.coach-signup-id').text();

        $(this).parent().remove();

        $.ajax({
            type: 'POST',
            url: '/Teams/RemoveStudentFromCoachAsync',
            data: JSON.stringify({
                coachSignUpId: parseInt(coach),
                studentSignUpId: parseInt(student)
            }),
            contentType: 'application/json; charset=utf8',
            dataType: 'text',
            success: function(data) {
                if (data === 'true') {
                    console.log("Removed");
                } else {
                    console.log("An error occurred");
                }
            }
        });
    });
});