export default {
  state: {
    toast: false,
  },
  mutations: {
    updateToast(state, payload) {
      state.toast = payload;
    },
  },

  actions: {
    setToast({ commit }, data) {
      commit("updateToast", data);
    },
  },
  getters: {
    getToast(state) {
      return state.toast;
    },
  },
};
