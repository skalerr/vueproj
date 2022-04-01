import { createStore } from "vuex";
import axios from "axios";
import toast from "./modules/toast.js";

export default createStore({
  modules: {
    toast,
  },
  state: {
    settings: {},
    // певрым массив с настройками (1)
  },
  mutations: {
    // (3)
    // не забывать синтаксис :
    // первый агрумент стейт
    // вторым аргументом проносим настройки
    SET_SETTINGS_TO_STATE: (state, settings) => {
      // задаем имя
      state.settings = settings;
    },
  },
  actions: {
    // (2)
    GET_SETTINGS_FROM_API({ commit }) {
      return (
        axios
          .get("api/Settings", {
            responseType: "json",
          })
          // axios("http://localhost:7296/", {
          //   method: "GET",
          // })
          // return axios.get ("http://localhost:3000/settings") укороченная версия
          // запрос с методом гет json-server -watch db.json

          .then((settings) => {
            //вызываем мутацию с нагрузкой (сеттингс) NOTE: не забыть про data
            commit("SET_SETTINGS_TO_STATE", settings.data);
            console.log("store get");
            // возвращаем настройки
            return settings;
          })
          // отлов ошибок
          .catch((error) => {
            console.log(error);
            console.log("ошибка аксиоса стейт");

            return error;
          })
      );
    },
    // GET_SETTINGS_FROM_API({  }) {
    //   return axios("http://localhost:3000/settings", {
    //     method: "GET",
    //   }).then((settings) => {
    //     commit("SET_SETTINGS_TO_STATE", settings)
    //   })
    // },
  },
  getters: {
    SETTINGS(state) {
      return state.settings;
    },
  },
});
