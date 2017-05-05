$(document).ready(function() {
    $('#student-list').tablesorter();
    $('#coach-list').tablesorter();

    $('.summoner-card').draggable({ stack: '.summoner-card' });
    $('.coach-card').droppable({
        drop: function(event, ui) {
            if ($(ui.draggable).hasClass('student-card')) {
                $.ajax({
                    type: 'POST',
                    url: 'Teams/AddStudentToCoach',
                    data: {coachName : $(this), coachServer: "", studentName: "", studentServer: ""},
                    contentType: 'application/json; charset=utf8',
                    dataType: 'json',
                    success: function() {
                        $(ui.draggable).hide();
                    }
                });
            }
        }
    });
});