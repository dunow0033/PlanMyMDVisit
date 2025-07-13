import { Calendar } from '@fullcalendar/core';
import dayGridPlugin from '@fullcalendar/daygrid';
import timeGridPlugin from '@fullcalendar/timegrid';
import listPlugin from '@fullcalendar/list';

let eventsArr = [];


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
            events: [
                {
                    title: "Record a video for Marisa",
                    start: "2025-06-20"
                },
            ],
        });
    //}

    calendar.render()
});


