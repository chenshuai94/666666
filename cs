<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
   <script src="https://cdnjs.cloudflare.com/ajax/libs/vue/2.5.17-beta.0/vue.common.js"></script>
</head>
<body>
    <div id="box">
        <input type="range" min="0" max="255" v-model="r"/>
        <input type="range" min="0" max="255" v-model="g"/>
        <input type="range" min="0" max="255" v-model="b"/>
        <input type="number" v-model="w"/>
        <input type="number" v-model="h"/>
        <div v-bind:style="{'width':w+'px','height':h+'px',background:'rgb('+r+','+g+','+b+')'}"></div>
    </div>

    <script>
        new Vue({
            el:"#box",
            data:{
                r:0,
                g:0,
                b:0,
                w:100,
                h:100
            }
        })
    </script>
</body>
</html>
