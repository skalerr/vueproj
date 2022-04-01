<template>
  <div class="list">
    <navigation />
    <List1 />
  </div>
</template>

<script>
import navigation from "../components/Home/navigation.vue";
import List1 from "../components/List/index.vue";
// import viewbody from "../components/viewbody.vue";

export default {
  name: "List",
  components: {
    navigation,
    List1,
  },
};
</script>

<style></style>
