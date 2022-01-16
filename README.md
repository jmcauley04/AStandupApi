# A Standup Api
An app for logging daily activities and logging notes during daily standup meetings.  I spent about 4 hours throwing it together.  
There are a lot of possible improvements, but it's in a working state.  I may or may not improve it in the future.

*Note: This app does use SQLite and will create a folder in your %APPDATA% (local) folder.*

## "Why did you make this?"
I believe in the agile methodology and one aspect of that is having daily standup meetings;  I recognize that I am not very good at 
remembering the less interesting, but sometimes time consuming, parts of my previous day.  As a result, I have taken to writing down
what I was just spending time on and recording the time when I switch to a new task.

This app handles all of the busy work in doing that so that I can simply scribble a note, hit the Submit button, and move on.

## Using the App

I didn't build an installer so the process is a little busy

### The "install"
1. Clone the repo
2. Build the release (feel free to modify the code for your needs)
3. Move the built folder to somewhere you'd like to keep it (Program Files perhaps)
4. Drag a link to AStandupApi.exe to your shortcut bar

### Taking a note
1. Open the app
2. Write down a note
3. Press submit.  

You can cancel if you changed your mind prior to submitting.

### Attending a meeting
1. Open the app to start the meeting time recorder
2. Press the "Meeting Mode" button 
3. Take notes in something like Word to have rich text or type directly into the textbox
4. Paste the notes into the app when you're done.

You can 'End Meeting' to not save the time and notes.  The app automatically creates an activity for the meeting.

### Daily Standup
1. Go to meeting mode
2. Use the data loaded to assist with your meeting
