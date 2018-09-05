;
(function (root, factory) {
    if (typeof define === 'function' && define.amd) {
        // AMD
        define(['three'], factory)
    } else if (typeof exports === 'object') {
        // Node, CommonJS-like
        module.exports = factory(require('three'))
    } else {
        // Browser globals (root is window)
        root.GazeEvent = factory(root.THREE)
    }
}(this, function (THREE) {
    //    methods
    function gazeEvent() {
        this.raycaster = new THREE.Raycaster();
        this.center = new THREE.Vector2();
        this.gazeList = {}, this.meshList = [];
        this.Gazing = false;
        this.target = null;

    }
    gazeEvent.prototype = {

        watch: function (mesh, gazeEnter, gazeExit) {
            this.gazeList[mesh.id] = {
                mesh,
                gazeEnter,
                gazeExit
            };
            this.meshList = Object.keys(this.gazeList).map(key => this.gazeList[key].mesh);
        },
        off: function (mesh) {
            delete this.gazeList[mesh.id];
            this.meshList = Object.keys(this.gazeList).map(key => this.gazeList[key].mesh);
        },
        clear: function () {
            this.gazeList = {}, this.meshList = [];
        },
        update: function (camera) {
            if (this.meshList.length <= 0) return;
            //创建凝视器
            this.raycaster.setFromCamera(this.center, camera);
            const intersects = this.raycaster.intersectObjects(this.meshList);

            if (intersects.length > 0) { //凝视触发
                if (this.Gazing) return; //只触发一次
                this.Gazing = true;
                this.target = intersects[0].object;
                this.gazeList[this.target.id].gazeEnter();
            } else {
                this.Gazing && this.gazeList[this.target.id].gazeExit();
                this.Gazing = false;
                this.target = null;
            }
        }
    }
    //    exposed public method
    return gazeEvent
}));
