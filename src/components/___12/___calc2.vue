<template>
  <div>text</div>
</template>

<script>
import { mapActions, mapGetters, mapState } from "vuex"

export default {
  name: "calc",
  props: {},
  components: {},
  computed: {
    ...mapGetters([
      // добавляем переменную сетингс
      "SETTINGS",
    ]),
    ...mapState(["settings"]),
  },
  methods: {
    ...mapActions(["GET_SETTINGS_FROM_API"]),
  },

  data() {},
  mounted() {
    this.GET_SETTINGS_FROM_API()
      // скрипт для после прогрузки настроек
      .then((Response) => {
        if (Response.data) {
          console.log("data arrived")
        }
      })
  },
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.container {
  text-align: center;
}
/* h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
} */
body {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  background: #f1f1f1;
}

h3 {
  margin-top: 0;
}

.example {
  background: #ffffff;
  margin: 20px;
  border-color: #e7e7e7;
  padding: 40px;
}

.example pre {
  background: #f9f9f9;
  padding: 18px 6px;
  overflow-x: scroll;
  margin-top: 10px;
}

.output {
  font-family: Courier, Courier New, Lucida Console, Monaco, Consolas;
  background: #000000;
  color: #ffffff;
  padding: 20px;
  margin-bottom: 50px;
  display: inline-block;
  width: 100%;
  box-sizing: border-box;
  font-size: 13px;
}

.slider-vertical {
  margin: -30px auto 0;
}

/* V-catalog-item
  v-for="product in this.$store.state.products"
   :key="product.article"
   :product_data="product"
  @sendDataToParent="showChildArticleInConsole" */
</style>
