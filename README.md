# CatapultUnity
Unity Project implementing the Catapult

Unity 5.5.2f1 - Switch to Android Platform before running the Project  in Editor and Enable Maximize on Play for better view.

The project defines only the functionality in the Free Aspect of the Camera in Editor. Cases such as different resolutions are not tested.

The Catapult is implemented using the velocity concept based on the distance b/w the catapult and the projectile (ball).

The Basic Idea of implementation,
  1. When the ball is dragged, the distance b/w the catapult and the ball is caluclated.
  2. From the distance , the square magnitude is multiplied with some scale factor to determine the speed with which the ball has to be         throwed.
  3. The same distance vector is used to determine the direction of the ball throw.
  4. The speed is multiplied with direction to determine the Velocity that will be apllied on the ball.
  5. On releasing the finger, the velcoity is applied over the ball , which gives the effect of throw of ball.
  6. Knowing the velocity and initial position of ball, projectile path will be traced using the gravity.( Formula of Math to trace             Projectile)

