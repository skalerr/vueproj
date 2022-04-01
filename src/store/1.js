import { createStore } from "vuex"
// import Vue from "vue"
// import Vuex from "vuex"
// import axios from "axios"
import settings from "./modules/settings"

export default createStore({
  modules: {
    settings,
  },
})
