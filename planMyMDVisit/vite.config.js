export default {
    optimizeDeps: {
        include: ['@fullcalendar/core', '@fullcalendar/list']
    },
    build: {
        outDir: "wwwroot/dist", // Output built files to wwwroot/dist
        emptyOutDir: true, // Clears previous build files
        rollupOptions: {
            input: {
                calendar: "./wwwroot/js/Calendar.js", // Explicit entry file
            },
            output: {
                entryFileNames: "[name].js", // Output keeps filename
            },
        },
    },
};