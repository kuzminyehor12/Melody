export const toDurationString = (duration: number) => {
    let minutes = Math.floor(duration / 60);
    let minutesAsString = (minutes >= 10) ? minutes : "0" + minutes;
    let seconds = Math.floor(duration % 60);
    let secondsAsString = (seconds >= 10) ? seconds : "0" + seconds;
    return minutesAsString + ":" + secondsAsString;
}