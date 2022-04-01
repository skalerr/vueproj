<template>
  <div class="home">
    <navigation />
    <viewbody />
    <calc />
    <range hidden />
    <!-- <HelloWorld msg="Welcome to Your Vue.js App" /> -->
  </div>
</template>

<script>
// @ is an alias to /src
// import HelloWorld from "@/components/HelloWorld.vue"
import viewbody from "../components/Home/viewbody.vue";
import range from "../components/Home/range.vue";
import calc from "../components/Home/calc.vue";
import navigation from "../components/Home/navigation.vue";
export default {
  name: "Home",
  components: {
    // HelloWorld,
    navigation,
    calc,
    viewbody,
    range,
  },
};
</script>
