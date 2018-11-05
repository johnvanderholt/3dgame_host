﻿class createObject {
    constructor(sizeX, sizeY, sizeZ, name, cast, receive) {
        var geometry = new THREE.BoxGeometry(sizeX, sizeY, sizeZ);
        var cubeMaterials;
        if (name === "cube") {
            cubeMaterials = [
                new THREE.MeshPhysicalMaterial({ map: new THREE.TextureLoader().load("textures/JukeboxTexLg.png"), side: THREE.FrontSide }), //LEFT
                new THREE.MeshPhysicalMaterial({ map: new THREE.TextureLoader().load("textures/JukeboxTexLg.png"), side: THREE.FrontSide }), //RIGHT
                new THREE.MeshPhysicalMaterial({ map: new THREE.TextureLoader().load("textures/JukeboxTex.png"), side: THREE.FrontSide }), //TOP
                new THREE.MeshPhysicalMaterial({ map: new THREE.TextureLoader().load("textures/JukeboxTex.png"), side: THREE.FrontSide }), //BOTTOM
                new THREE.MeshPhysicalMaterial({ map: new THREE.TextureLoader().load("textures/JukeboxTexLg.png"), side: THREE.FrontSide }), //FRONT
                new THREE.MeshPhysicalMaterial({ map: new THREE.TextureLoader().load("textures/JukeboxTexLg.png"), side: THREE.FrontSide }) //BACK
            ];
        }
        else if (name === "plane") {
            cubeMaterials = [
                new THREE.MeshPhongMaterial({ visible: false }), //LEFT
                new THREE.MeshPhongMaterial({ color: 0xD8D8D8, side: THREE.FrontSide }), //RIGHT
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/IronTex.png"), side: THREE.FrontSide }), //TOP
                new THREE.MeshPhongMaterial({ visible: false }), //BOTTOM
                new THREE.MeshPhongMaterial({ color: 0xD8D8D8, side: THREE.FrontSide }), //FRONT
                new THREE.MeshPhongMaterial({ color: 0xD8D8D8, side: THREE.FrontSide }) //BACK
            ];
        }
        else if (name === "fragile") {
            cubeMaterials = [
                new THREE.MeshPhongMaterial({ visible: false }), //LEFT
                new THREE.MeshPhongMaterial({ color: 0x6E6553, side: THREE.FrontSide }), //RIGHT
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/IronFragileTex.png"), side: THREE.FrontSide }), //TOP
                new THREE.MeshPhongMaterial({ visible: false }), //BOTTOM
                new THREE.MeshPhongMaterial({ color: 0x6E6553, side: THREE.FrontSide }), //FRONT
                new THREE.MeshPhongMaterial({ color: 0x6E6553, side: THREE.FrontSide }) //BACK
            ];
        }
        else if (name === "trigger") {
            cubeMaterials = [
                new THREE.MeshPhongMaterial({ visible: false }), //LEFT
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/GoldTex.png"), side: THREE.FrontSide }), //RIGHT
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/GoldTex.png"), side: THREE.FrontSide }), //TOP
                new THREE.MeshPhongMaterial({ visible: false }), //BOTTOM
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/GoldTex.png"), side: THREE.FrontSide }), //FRONT
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/GoldTex.png"), side: THREE.FrontSide }) //BACK
            ];
        }
        else if (name === "bridge") {
            cubeMaterials = [
                new THREE.MeshPhongMaterial({ visible: false }), //LEFT
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/PlanksTex.png"), side: THREE.FrontSide }), //RIGHT
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/PlanksTex.png"), side: THREE.FrontSide }), //TOP
                new THREE.MeshPhongMaterial({ visible: false}), //BOTTOM
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/PlanksTex.png"), side: THREE.FrontSide }), //FRONT
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/PlanksTex.png"), side: THREE.FrontSide }) //BACK
            ];
        }
        else if (name === "end") {
            cubeMaterials = [
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/DiamondTex.png"), side: THREE.BackSide }), //LEFT
                new THREE.MeshPhongMaterial({ visible: false }), //RIGHT
                new THREE.MeshPhongMaterial({ visible: false }), //TOP
                new THREE.MeshPhongMaterial({ visible: false }), //BOTTOM
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/DiamondTex.png"), side: THREE.BackSide }), //FRONT
                new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/DiamondTex.png"), side: THREE.BackSide }) //BACK
            ];
        }
        else if (name === "end2") {
            cubeMaterials = [
                new THREE.MeshPhongMaterial({ visible: false }), //FRONT
                new THREE.MeshPhongMaterial({ color: 0x00000, side: THREE.FrontSide }), //BACK
                new THREE.MeshPhongMaterial({ visible: false }), //TOP
                new THREE.MeshPhongMaterial({ visible: false }), //BOTTOM
                new THREE.MeshPhongMaterial({ color: 0x00000, side: THREE.FrontSide }), //LEFT
                new THREE.MeshPhongMaterial({ color: 0x00000, side: THREE.FrontSide }) //RIGHT
            ];
        }

        var material = new THREE.MeshFaceMaterial(cubeMaterials);
        var object = new THREE.Mesh(geometry, material);

        object.name = name;
        object.castShadow = cast;
        object.receiveShadow = receive;

        return object;
    }
}