"use strict";
exports.__esModule = true;
var like_component_1 = require("./like.component");
var component = new like_component_1.LikeComponent(10, true);
component.onClick();
console.log("likesCount: ".concat(component.likesCount, ", isSelect: ").concat(component.isSelected));
