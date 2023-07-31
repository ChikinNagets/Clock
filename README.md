# Considerations

### When Developing an app for IPad or VR some things to conser are:

When developing an application for VR or IPAD devices in Unity, there are several important factors to consider to ensure that the application is usable and comfortable for users as well as optimized. Here are some key considerations:

** IPad Considerations **

1. Screen resolution: iPads have different screen resolutions depending on the model, so make sure your application is designed to fit the most common resolutions.

2. Touch controls: Since the iPad uses touch controls, you should consider optimizing your application for touch input. This might mean adjusting button sizes, making sure buttons are spaced out enough, and testing your application's touch input on an actual iPad device.

3. Memory usage: While newer iPad models have a lot of memory, older models might not, so you should keep your application's memory usage in mind when designing it. This means optimizing textures, reducing the number of draw calls, and making sure your application isn't unnecessarily resource-intensive.

4. Orientation: iPads can be used in both portrait and landscape orientations, so your application should support both orientations and be designed to function well in both.

5. iOS compatibility: Make sure your application is compatible with the latest version of iOS that's supported on iPad devices. This means testing your application on the latest version of iOS and making any necessary adjustments to ensure it works properly.

** VR Conseiderations **

1. User experience: VR is an immersive technology, so it's important to create an experience that is comfortable and engaging for users. This means paying attention to things like frame rate, motion sickness, and the overall user interface.

2. Device compatibility: There are several different VR devices on the market, each with its own requirements and capabilities. Make sure to test your application on a variety of devices and optimize it accordingly.

3. Interaction: In VR, users interact with the environment using motion controllers or other input devices. It's important to design intuitive and natural interactions that are easy for users to understand and use.

4. Performance: VR applications require high performance to maintain a smooth and responsive experience. This means optimizing your application for performance, reducing the number of draw calls, and minimizing the use of resources like textures and lighting.

5. Comfort: VR can be an intense experience, so it's important to design your application with user comfort in mind. This might mean providing options for adjusting the field of view, reducing the use of bright or flashing lights, and ensuring that users have enough space to move around.

Overall, when developing an application in Unity, it's important to prioritize the user experience and optimize your application for performance and comfort. 

### Final remarks

Regading code, some functions can be globilized to be reusable making the app a bit more optimized, having a global accessible file called 'utils/utils' could be useful for this purpose.
Icons were used to keep ui clean and simple, aided with simple text to help user identify the different buttons.
Due to time constraints responsivnes was not considered for this excercise, making the app usable in PC but not in other devices.

Due to Unity's treatment of git locked files, use the current `.gitignore` file for future projects as template. 

## TODO

1. Get input for user
2. Use user input to set desired timer
	+ ~Timer can be 15s maximum~
	+ ~Timer set on enter~
	+ ~Timer can be paused/stopped/reset~
	+ ~Timer is reset to user input~
3. Fix timer and stopwatch bug
	+ ~when timer or stopwatch is stopped, when retsetting time it is not reflected until user clicks play again.~
