import { Calendar } from '@fullcalendar/core';
import dayGridPlugin from '@fullcalendar/daygrid';
import timeGridPlugin from '@fullcalendar/timegrid';
import listPlugin from '@fullcalendar/list';
import { req } from 'superagent';

let eventsArr = [];


//document.addEventListener('DOMContentLoaded', function () {
//    const calendarEl = document.getElementById('calendar');

//    //if (calendarEl) {
//    const calendar = new Calendar(calendarEl, {
//            plugins: [dayGridPlugin, timeGridPlugin, listPlugin],
//            initialView: 'dayGridMonth',
//            headerToolbar: {
//                left: 'prev, next today',
//                center: 'title',
//                right: 'dayGridMonth, timeGridWeek, listWeek'
//            },
//            events: [
//                {
//                    title: "Record a video for Marisa",
//                    start: "2025-06-20"
//                },
//            ],
//        });
//    //}

//    calendar.render()
//});


//var calendar = new Calendar(calendarEl, {

//    events: function (info, successCallback, failureCallback) {
//        req.get('https://localhost:7189')
//            .type('json')
//            .query({
//                start: info.start.valueOf(),
//                end: info.end.valueOf()
//            })
//            .end(function (err, res) {

//                if (err) {
//                    failureCallback(err);
//                } else {

//                    successCallback(
//                        Array.prototype.slice.call( // convert to array
//                            res.getElementsByTagName('event')
//                        ).map(function (eventEl) {
//                            return {
//                                title: eventEl.getAttribute('title'),
//                                start: eventEl.getAttribute('start')
//                            }
//                        })
//                    )
//                }
//            })
//    }

//});

document.addEventListener('DOMContentLoaded', function () {
    const calendarEl = document.getElementById('calendar');

    //if (calendarEl) {
    const calendar = new Calendar(calendarEl, {
        plugins: [dayGridPlugin, timeGridPlugin, listPlugin],
        initialView: 'dayGridMonth',
        headerToolbar: {
            left: 'prev, next today',
            center: 'title',
            right: 'dayGridMonth, timeGridWeek, listWeek'
        },
        //events: 'https://localhost:7189/HealthCareTeams/patientList/1A0B71B3-61E4-4096-B647-70FAE91590DB',
        events: function (fetchInfo, successCallback, failureCallback) {
            fetch('/HealthCareTeams/patientList/1A0B71B3-61E4-4096-B647-70FAE91590DB', {
                headers: {
                    'Accept': 'application/json'
                }
            })
                .then(response => response.json())
                .then(data => successCallback(data))
                .catch(err => failureCallback(err)),
               }

    });
   
    //}

    calendar.render()
});

//var calendar = new Calendar(calendarEl,
//    {
//        //$.ajax({
//        events: {
//            url: 'https://localhost:7189/HealthCareTeams/patientList/1A0B71B3-61E4-4096-B647-70FAE91590DB',
//            type: 'GET',
//            method: 'json'
//                .query({
//                    start: info.start.valueOf(),
//                    end: info.end.valueOf()
//                })
//                .end(function (err, res) {

//                    if (err) {
//                        failureCallback(err);
//                    } else {

//                        successCallback(
//                            Array.prototype.slice.call( // convert to array
//                                res.getElementsByTagName('event')
//                            ).map(function (eventEl) {
//                                return {
//                                    title: eventEl.getAttribute('title'),
//                                    start: eventEl.getAttribute('start')
//                                }
//                            })
//                        )
//                    }
//                })
//        }
//    //)};

//});