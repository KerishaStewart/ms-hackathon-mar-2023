const agenda = document.querySelector('mgt-agenda');
agenda.addEventListener('eventClick', (e) => {
    var subject = e.detail.event.subject;
    var start = e.detail.event.start.dateTime
})

function getMeetingStart(subject, start) {

}