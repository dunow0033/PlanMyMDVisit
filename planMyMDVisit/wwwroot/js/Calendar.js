import { Calendar } from '@fullcalendar/core';
import dayGridPlugin from '@fullcalendar/daygrid';
import listPlugin from '@fullcalendar/list';

const calendarEl = document.getElementById('calendar');

const calendar = new Calendar(calendarEl, {
    plugins: [dayGridPlugin, listPlugin],
    initialView: 'dayGridMonth',
    headerToolbar: {
        left: 'prev, next today',
        center: 'title',
        right: 'dayGridMonth, timeGridWeek, timeGridDay'
    },
    events: [
        {
            title: "Record a video for Marisa",
            start: "2020-11-14",
        },
    ],
});

calendar.render()