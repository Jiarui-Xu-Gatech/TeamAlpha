1. Starting scene file
 GameplayScene
 
2. How to play and what parts of the level to observe technology requirements
2.1 How to play
 You are a lonely adventurer trapped in a maze. 
 There are 3 layers in this maze. 
 You need to gather 3 mushrooms which serve as keys to in each layer. 
 With all 3 mushrooms collected, you can enter the next layer or Freedom!
 Control: WASD: move, E: gather mushroom, space: Jump
 Mechanism: There are many ancient maze guardians spread among the game field, 
            who will chase you if they see you. Please dodge their attack! 
            Your HP is 100 originally. Maximum is 120. When your HP reaches 0, 
            the game will end. Each gold coin encountered 
            (No need to specifically gather them) will increase your current HP by 20.

2.2 what parts of the level to observe technology requirements
2.2.1 It must be a 3D Game Feel game
 Our player and npcs could run in a 3D maze with a camera following the player.
 Play can finish game by gathering 3 mushrooms in 3 layers while dodging the attack from npcs.
 When the game runs out of time or the HP of th player drops down to 0, the gameover scene will show.
 If the player successfully clear all the three option levels, the success scence will show.
 There is a start menu when game starts and game reloads.
 The game can be reloaded after player dies.
 It is not a first-person perspective games.
2.2.2 Precursors to Fun Gameplay
 We have a help menu to help players to understand the goal of the game.
 The player could choose different option levels for the game.
 If the player selects more difficult option level, the game will tend to be harder.
 Player can choose to collect coins for a recovery of HP.
 Player could learn experience in interacting with npcs.
 The difficulty of different option levels will increase as game promotes.
2.2.3 3D Character with Real-time Control
 We could control our charactor to run ahead, backwards, turn left, right and pick muhshrooms.
 Our player controll is continuous, dynamic and with low latency.
 Our player has fluid animation with states changing from one to another.
 We use root motion so our player will not slide or moonwalk.
 Our camera will turn an angle according to the animation of the palyer.
2.2.4 3D World with Physics and Spatial Simulation
 Our player and npcs will have colliders which will trigger event for animation.
 We design the floor plan of the maze to generate appropriate routes for the game.
 Our player will not run through any gameobjects such as walls.
 Player could pickup mushrooms and coins while exploring the maze.
 Both playe and npcs use Mecanim to make animation and state transformation.
2.2.5 Real-time NPC steering behaviors/ Artifacial intelligence
 We use navmesh to path planning routes for npcs.
 We make idle, walk and jump(attack) animation tranformation accordind to state change.
 Npcs will change their collider size after they notice there is a player near.
 For more difficult level option, there will be more npcs.
 Npc will walk at a max speed which is slower than the player.
2.2.6 Polish
 We implement a start menu GUI.
 We implement in-game pause menu with ability to quit game.
 Our game has a same tyle from the beginning to the end.
 Our game can be existed at any time.
 There are swaying trees, grass and snow mountain in the scene.
 We make background music with ups and downs according to the game flow.
 Our game's name is maze of fear so the style is wild and dark.
 Our game has no glitches, easily escaping the confines of the game world, no obvious edge of the game world.

3. Known problem areas
3.1 Three option levels might not be enough for those who are enjoying our game.
3.2 Npc might seem silly since they will tend to have same motion once they get to a same location.
3.3 The interactive contents in game might not be enough.

4. Manifest of which files athoured by each teammate:
4.1 Detail who on the team did what
 Yilong Chen:  npc animation, navmesh path plan, npc-blood interaction
 Jiarui Xu  :  maze generation, camera adjust, game pro create, scene create, make videos
 Chunxuan Zhu: main char motions and interactions, level collectible setting
 Zongen Li:    coding environment, miniMap, game pass/final goal
 Lintong Han:  options level, pause menu

4.2 For each team member, asset implemented
 Yilong Chen:  NPCs(unity store), Timer-Canvas-blood, Timer-Canvas-remain
 Jiarui Xu:    SmallWallForDuplicate, SmallWallForDuplicate2, SmallWallForDuplicate3
               SmallWallForDuplicate4, MazeWall, MazeWall2, MazeWall3, MazeWall4
               OuterWalls, BackgroundMusic, Plants
 Chunxuan Zhu: Protagonist(unity store)
 Zongen Li:    Terrain(Flowers,grass,snow mountain texture from unity store),
               MiniMap Icons(unity store), MiniMap, FinalGoal
 Lintong Han:  timer, coins, GameOver, GameController, MushRoom, MushRoom(1), MushRoom(2)

4.3 C# script files individually
 Yilong Chen:  npcController.cs, BloodGameOver.cs
 Jiarui Xu:    Position.cs, AudioManager.cs
 Chunxuan Zhu: levelLoader.cs, BallCollector.cs, CollectBall.cs, Basic_control.cs, 
               CoinScript.cs, Controller_input.cs, BloodGameOver.cs 
 Zonge Li:     levelLoader.cs
 Lintong Han:  levelSetup.cs, CoinScript.cs, PauseMenu.cs 