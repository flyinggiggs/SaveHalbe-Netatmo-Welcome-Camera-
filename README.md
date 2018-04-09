# NetatmoWelcomeCamera

This is an Android application detecting people's faces with Netatmo security camera and analyze their faces.
Users log in with Netatmo account and they set up Netatmo Security cameras in their places.
The Camera starts capturing passer's faces and send images to Microsoft Face Machine Learning API. 
After that, it gets analyzesd data from the API and displays age, gender, hair and smile.
You can enroll the passers to this application once the camera captures their faces.

Used Xamarin.
Used WelcomeHome API.
Used Microsoft Face API.

Save time to deserialize/serialize data by looking at Model classes under SaveHalbe.Core project. (This can be used for both IOS and Android)
