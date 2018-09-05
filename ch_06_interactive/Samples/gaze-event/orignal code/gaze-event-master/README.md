# gaze-event
gaze event for webvr threejs project

### Installation
1. `yarn add gaze-event` or `npm install --save gaze-event`
2. `import GazeEvent from 'gaze-event'` or `const gazeEvent = require('gaze-event)` in project with module bundler.

Of course,You can also use `<script src="gaze-event/index.js"></script>` without module bundler.

### How to use

```
// init scene, camera, renderer
...
// create crosshair here
// camera.add(createCrosshair());
// create cube
var cube = new THREE.Mesh( geometry, material );
scene.add(cube);

// Step1: init gazeEvent
var gazeEvent = new GazeEvent();

// Step2: add event listener for the cube
gazeEvent.watch(cube, function() => {
    cube.material.opacity = 0.5; // gazeEnter the cube
}, function() {
    cube.material.opacity = 1; // gazeExit the cube
});

function animate() { // animate function for requestAnimationFrame
    ...
    // update gazeEvent
    gazeEvent.update(camera);
    renderer.render(scene, camera);
}
```

### Orthers
1. remove gaze listener for a mesh
```
gazeEvent.off(mesh);
```
2. remove all gaze listeners
```
gazeEvent.clear();
```
## Need Help?

Ask questions [here](https://github.com/yonechen/gaze-event/issues).

## Any advise?

PR welcome [here](https://github.com/yonechen/gaze-event/pulls).

## Contributors

YoneChen <yorkchan94@gmail.com>

## License

MIT

Please Star this Project if you like it! Following would also be appreciated!