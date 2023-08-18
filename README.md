# Purplebricks
## Junior Role - 2020

## Objective 2 - 
I have chosen not to use a Picker as when I intially started reading the task my mind jumped to the style I have added.

> Issue

I wanted to use DynamicResources and change the style when the property changes, the problem is in HomePage.xaml.cs I didn't know how to get the ToLet variable from HomeViewModel.cs

> Solution

I had to use 2 ICommands as I had to hide 2 buttons based on the value, if I could've simply changed the style I would've done the following in the `Command Command(() => ToLet = !ToLet)`

This has taken the longest time simply because I wasn't sure what is the best approach to pass multiple parameters through `Navigate` for the `_toLet` variable. In the end I decided to just make a new class that has both the `LocationResult` and `ToLet`

## Objective 5 -

> Issue (VS 2019 Preview)

The one thing missing is the CarouselView/CollectionView as I had the same issue with both of them.
Reading the documentation for CarouselView because it is still in Preview I have to set the flag to allow experimental components to be used, when I tried that I got the following error: https://cdn.discordapp.com/attachments/268177342168301568/668210952289910821/unknown.png [CollectionView]
https://cdn.discordapp.com/attachments/268177342168301568/668211747768762368/unknown.png [CarouselView] 

I have also tried the following code:
```
Xamarin.Forms.Forms.SetFlags("CarouselView_Experimental");
Xamarin.Forms.Forms.Init(this, bundle); // Initializing the Actual Form but with no luck
Xamarin.Essentials.Platform.Init(this, bundle);
```

> Tried the following

- Clean and Rebuild Solution.
- Update the packages.
- Tried the initial repo with just the `Forms Init` and `Set Flags` but I was getting the same error.
- Googled the issues for several hours but couldn't find any solutions.
- Duplicated the project and tried the above code and update the package.
- Tried discord and gitter but no luck there either.

> Duplicating the project worked `Once`

So I duplicated the project added the above code and I was not getting the error, I was able to add the CarouselView into the XAML code and it was working, after a restart of VS 2019 it stopped working.
This makes me belive there might be something wrong with my VS or System as it doesn't make much sense, unfortunatelly I don't have another PC/Laptop to test it on.

> Solutions

- Create a ListView and rotate it 270 Deg as it doesn't allow Horizontal Orientation, then just rotate the children within the list.
- Download a Carousel package and try to use that.

> Changes

Floor Plan and StarPoints have not been placed on a new page or activity (if this is what you meant by page) as I thought it was better to just keep it on the same page. I did look at the purple bricks mobile app in the browser and copied some things.

## Goods & Bads

> Objective 1, is really simple so I don't think mentioning `Device.OpenUri` is needed.

> Objective 4, maybe giving some api returns example using different parameters or giving us access to some demo api to mess around with.

> Objective 5, again maybe giving us a full `JSON Object` example of a property for visualization purposes, it is not needed as the class `PropertyDetailsResult` has all the info in there but just a thought. 

## Questions
MenuViewModels - Is there a reason why you are delaying the task by 100 milliseconds on Android? I would assume is because you are waiting to load something but I doubt its that since I am not seeing anything in the code plus is only for Android and not iOS.

###### Highlight
Not sure if it matters how long I have spent working on these, but the time difference between commits do not reflect the actual time spent on the objectives.
Out of everything I have probably spent the most time trying to fix the `CarouselView/CollectionView` issues which I still haven't fixed (around 6-8 hrs)
