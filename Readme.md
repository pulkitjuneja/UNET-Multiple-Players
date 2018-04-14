After prowling the internet for hours, trying to find some good examples on how to customize the network manager to the features required for my game, It came to my notice there are barely any thorough tutorials or good examples on that matter. Hence, after a lot of experimenting and gleaning online forums for what I wanted, I decided to write this post in the hopes that it might be useful to a fellow developer going through the same ordeal  

## Advantages of using a custom network manager
Unity provide an in-built network manager that is really good for quick prototypoing. You just need to plug the script into a game object, drag and drop the spawnable prefabs into it, flip some switches and you are done with all the basic setup you need to create a multiplayer game. However using this script as is does take away a lot of flexibility that the Unity's networking system is actually capable of and that you might need in your game. Here are a few functionalities that you can achieve only by using a custom network manager 

* **Multiple Player Prefabs** - The built in network manager prefab allows you to specify only a single player prefab, meaning all the players in the game will look the same. While this might be good enough for a some basic games, this is definitely a limitation if your game requires different Player types or customizable players. Using a custom network manager would give you the option to spawn differnt player prefabs for different client connections.
* **Spawn Players on Demand and better position control** - While the in-build network manager will allow you to specify a list of spawn positions, sometimes a more granular control might be required. For example, suppose the game you are working on requires you to spawn players randomely within a certain area while also making sure they do not spawn over one of the many dyncamically moving obstacles. A very specific but common scenario, something that cant be accomplished using only the built-in network Manager.
* **Control over object instantiation** - Using a custom network manager, you can can take control over instantiating the player objects rather than letting the network manager do it for you. While this might be rarely required, it can again definetely be useful in many scenarios.

## What is the Network Manager
The network manager is a convinience Class present in the UnityEngine.Networking namespace. It acts as a core controlling component in a game using the Unity's provided [High Level API](https://docs.unity3d.com/Manual/UNetUsingHLAPI.html) networking system. 



