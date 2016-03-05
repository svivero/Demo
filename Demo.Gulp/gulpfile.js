/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');

// Requires the gulp-sass plugin
var sass = require('gulp-sass');

// pre-req --> npm install browser-sync --save-dev
var browserSync = require('browser-sync').create();

gulp.task('sass', function () {
    return gulp.src('app/scss/**/*.scss') // Gets all files ending with .scss in app/scss
      .pipe(sass())
      .pipe(gulp.dest('app/css'))
      .pipe(browserSync.reload({
          stream: true
      }))
});

gulp.task('browserSync', function () {
    browserSync.init({
        server: {
            baseDir: 'app',
        },
    })
})

// run 'gulp watch' to execute
// anytime a .scss or .js file is changed, the watch will call the 'sass' task
gulp.task('watch', ['browserSync', 'sass'], function () {
    gulp.watch('app/scss/**/*.scss', ['sass']);
    // Reloads the browser whenever HTML or JS files change
    gulp.watch('app/*.html', browserSync.reload);
    gulp.watch('app/js/**/*.js', browserSync.reload);
});
