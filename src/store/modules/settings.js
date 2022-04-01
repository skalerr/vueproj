export default {
  actions: {
    async fetchSettings(ctx) {
      const res = await fetch("http://localhost:3000/settings")
      const settings = await res.json()
      this.settings = settings

      ctx.commit("updateSettings", settings)
    },
  },
  mutations: {
    updateSettings(state, settings) {
      state.settings = settings
    },
  },
  state: {
    settings: [],
  },
  getters: {
    allSettings(state) {
      return state.settings
    },
  },
}
