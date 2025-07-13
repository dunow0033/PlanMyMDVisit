import { defineConfig } from 'vite';

export default defineConfig ({
    optimizeDeps: {
        include: ['@fullcalendar/core', '@fullcalendar/list']
    },
    build: {
        outDir: "wwwroot/dist", // Output built files to wwwroot/dist
        emptyOutDir: true, // Clears previous build files
        rollupOptions: {
            input: {
                calendar: "./src/Calendar.js", // Explicit entry file
            },
            output: {
                entryFileNames: "[name].js", // Output keeps filename
            },
        },
    },
});