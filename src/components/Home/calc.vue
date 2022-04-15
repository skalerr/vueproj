<template>
  <!-- v-model="Price" :tooltip="true" tooltipText="%v" -->
  <div class="container-md">
    <div class="row">
      <!-- style="height: 500px" -->
      <!-- col-lg-6 col-sm-6 -->
      <div class="col-lg-12 col-sm-12 mb-3">
        <div class="product-card card text-dark bg-light mb-3 ms-3">
          <!-- наполнение карточки -->
          <h5 class="card-header">Card</h5>
          <div class="card-body">
            <div class="container-md">
              <div class="row d-md-flex justify-content-around">
                <div class="range-slider col-lg-8 col-sm">
                  <div class="col d-flex justify-content-between">
                    <p class="d-flex justify-content-between flex-grow-1 mb-0">
                      <small>
                        <span class="border opop user-select-none">{{
                          `${minPrice} RUB`
                        }}</span> </small
                      ><small>
                        <span class="border user-select-none">{{ `${maxPrice} RUB` }}</span></small
                      >
                    </p>
                  </div>
                  <!-- ranger -->
                  <div class="range_container w-100">
                    <!--  слайдер -->
                    <Slider
                      class="slider-blue"
                      id="slider"
                      v-model="Price"
                      :format="format"
                      :max="maxPrice"
                      :step="stepPrice"
                      :min="minPrice"
                      :showTooltip="showTooltipPrice"
                      :options="{
                        pips: {
                          values: [0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100],
                          mode: 'positions',
                        },
                      }"
                      @change="anotherThing()"
                    />
                  </div>
                  <div class="mt-3 d-flex justify-content-start ps-3 pt-2 col-sm-12 col-lg-6">
                    <!-- <input v-bind:value="Price" /> 
                    поле ввода с привзкой к значению но без редактирования -->

                    <input
                      v-model.number="Price"
                      type="number"
                      min="1000"
                      max="30000"
                      step="1000"
                      class="form-control min-vw-25% vw-25%"
                      required
                      minlength="4"
                      @click="anotherThing2()"
                    />
                    <button
                      type="submit"
                      hidden
                      class="hidden d-block mx-auto btn btn-primary ps-2 ms-2"
                    >
                      Посчитать
                    </button>
                  </div>

                  <br />
                  <div class="range_container">
                    <!-- ползунок выбора дня -->
                    <Slider
                      id="slider_day"
                      v-model.number="day"
                      :format="formatday"
                      class="slider-blue"
                      :max="maxday"
                      :step="stepday"
                      :showTooltip="showTooltipday"
                      :min="minday"
                      :options="{
                        pips: {
                          values: [0, 20, 40, 60, 80, 100],
                          mode: 'positions',
                        },
                      }"
                    />
                  </div>
                  <div class="col d-flex justify-content-between">
                    <!-- 
                        числа слева и справа 1 и 30 
                        -->
                    <p class="d-flex justify-content-between flex-grow-1">
                      <small>
                        <!-- <span class="border user-select-none">{{ `${minday} Дн` }}</span> -->
                      </small>
                      <small>
                        <!-- <span class="border user-select-none">{{ `${maxday} Дн` }}</span> -->
                      </small>
                    </p>
                  </div>
                  <div class="d-flex justify-content-start pb-3 ps-3 pt-1 col-sm-12 col-lg-4">
                    <!-- поле ввода для дня -->
                    <input
                      oninput="this.value = Math.round((this.value / 1) * 1);"
                      v-model.number="day"
                      type="number"
                      min="1"
                      max="30"
                      step="1"
                      class="form-control w-100"
                      @change="dayround()"
                    />
                  </div>

                  <!-- <a href="#" class="btn btn-primary my-2 d-flex justify-content-end">
                    <h2>Призыв к действию</h2></a
                  > -->
                </div>
                <!-- 
                  range-values
                 -->
                <div class="range-values col-lg-4 col-sm pb-3">
                  <div class="card text-dark border-success mb-3 ms-3">
                    <div class="card-header">Хедер</div>
                    <div class="card-body">
                      <h5 class="card-title">
                        <!-- 
                            проверка суммы на любое количество
                           -->
                        <!-- <p>{{ totalsum() }}</p> -->
                        <p>Итого: {{ minPriceComputed }} рублей</p>

                        <!-- <p>Итого {{ outputall() }} рублей</p> -->
                      </h5>
                      <div class="card-text">
                        <!-- <p v-if="Price >= 1000">Сумма: {{ Price }} рублей</p>
                          <p v-else-if="Price < 1000">Сумма: {{ minPrice }} рублей</p> -->
                        <!-- <p>Сумма: {{ Price }} рублей</p> -->
                        <p>Сколько хотите взять: {{ Price >= 1000 ? Price : minPrice }} рублей</p>

                        <p>На какое количество дней: {{ day }} дней</p>
                        <p hidden>
                          Процент который нужно будет оплатить
                          {{ outputPercent() }} рублей {{}}
                        </p>
                        <p hidden>Итого {{ outputall() }} рублей</p>
                        <p>К какой дате необходимо вернуть {{ dni() }}</p>
                        <!-- <div class="" v-for="setting in SETTINGS" :key="setting.title"> -->
                        <!-- <div>
                            <h2>{{ SETTINGS.summ }}</h2>
                            <p>{{ SETTINGS.day }}</p>
                            <p>{{ Number(SETTINGS.percentDay) }}</p>
                          </div> -->
                      </div>
                      <div class="text-center">
                        <button
                          type="button"
                          class="btn btn-outline-success d-flex justify-content-center btn-block btn-lg d-block mx-auto"
                          data-bs-target="#takesumm"
                          @click="openmodal()"
                        >
                          Взять
                        </button>
                        <!-- data-bs-toggle="modal" -->
                        <!-- Modal -->
                        <!-- <div
                          class="modal fade"
                          id="takesumm1"
                          tabindex="-1"
                          aria-labelledby="exampleModalLabel"
                          aria-hidden="true"
                        >
                          <div class="modal-dialog modal-dialog-centered">
                            <div class="modal-content">
                              <div class="modal-header">
                                <h5 class="modal-title" id="exampleModalLabel">Form</h5>

                                <button
                                  type="button"
                                  class="btn-close"
                                  data-bs-dismiss="modal"
                                  aria-label="Close"
                                ></button>
                              </div>
                              <div class="modal-body">
                                <form action="">
                                  <div class="row mb-3">
                                    <label for="inputEmail" class="col-sm-2 col-from-label"
                                      >Ваш Email</label
                                    >
                                    <div class="col-sm-10">
                                      <input type="email" class="form-control" id="inputEmail" />
                                    </div>
                                  </div>
                                  <div class="row mb-3">
                                    <label for="inputNumber" class="col-sm-2 col-from-label"
                                      >Номер Телефона</label
                                    >
                                    <h5 class="modal-title" id="exampleModalLabel">New message</h5>

                                    <div class="col-sm-10">
                                      <input type="password" class="form-control" id="inputPass" />
                                    </div>
                                  </div>
                                  <div class="row mb-3">
                                    <label for="exampleFormControlInput1" class="form-label"
                                      >Email address</label
                                    >
                                    <input
                                      type="email"
                                      class="form-control"
                                      id="exampleFormControlInput1"
                                      placeholder="name@example.com"
                                    />
                                  </div>
                                </form>
                              </div>
                              <div class="modal-footer">
                                <button class="btn btn-secondary">Отправить</button>
                                <button class="btn btn-secondary" data-bs-dismiss="modal">
                                  Закрыть
                                </button>
                              </div>
                            </div>
                          </div>
                        </div> -->
                        <div
                          class="modal fade"
                          id="takesumm"
                          tabindex="-1"
                          aria-labelledby="exampleModalLabel"
                          aria-hidden="true"
                        >
                          <div class="modal-dialog">
                            <div class="modal-content">
                              <div class="modal-header">
                                <h5 class="modal-title" id="exampleModalLabel">New message</h5>
                                <button
                                  type="button"
                                  class="btn-close"
                                  data-bs-dismiss="modal"
                                  aria-label="Close"
                                ></button>
                              </div>
                              <div class="modal-body">
                                <form>
                                  <div class="form-floating mb-3">
                                    <input
                                      type="name"
                                      class="form-control"
                                      id="inputname"
                                      placeholder-shown="name@example.com"
                                      required
                                      v-model="user.inputname"
                                    />
                                    <label for="inputname">Ваше имя</label>
                                  </div>
                                  <div class="form-floating mb-3">
                                    <input
                                      type="email"
                                      class="form-control"
                                      id="inputemail"
                                      placeholder-shown="name@example.com"
                                      required
                                      v-model="user.inputemail"
                                    />
                                    <label for="inputemail">Email address</label>
                                  </div>

                                  <div class="form-floating mb-3">
                                    <input
                                      type="tel"
                                      class="form-control"
                                      id="inputtel"
                                      placeholder-shown="7-999-999-99-99"
                                      minlength="11"
                                      maxlength="15"
                                      v-model="user.inputtel"
                                      required
                                    />

                                    <label for="inputtel">Номер телефона</label>
                                  </div>
                                </form>
                              </div>
                              <div class="modal-footer">
                                <button
                                  type="button"
                                  class="btn btn-secondary"
                                  data-bs-dismiss="modal"
                                >
                                  Закрыть
                                </button>
                                <button
                                  type="button"
                                  @click="senddatafrommodal"
                                  class="btn btn-primary"
                                >
                                  Отправить
                                </button>
                                <button type="button" @click="modalwindow" class="btn btn-primary">
                                  спрятать
                                </button>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>

                    <!-- @Slider="$emit('update:Price', $event.target.value)" -->
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <button @click="onclickbtn()" type="button" class="btn btn-primary" id="liveToastBtn">
      Show live toast
    </button>
    <button @click="onclick()" type="button" class="btn btn-primary" id="liveToastBtn">
      bootstrap toats
    </button>
    <button type="button" @click="modalwindow" class="btn btn-primary">спрятать</button>

    <div class="position-fixed bottom-0 end-0 p-3" style="z-index: 11">
      <div
        id="liveToast"
        class="toast"
        role="alert"
        aria-live="assertive"
        aria-atomic="true"
        ref="toast"
        data-bs-delay="99999"
      >
        <div class="toast-header">
          <img src="" class="rounded me-2" alt="" />
          <strong class="me-auto">Заявка</strong>
          <small>Сделать временую отметку</small>
          <button
            type="button"
            class="btn-close"
            data-bs-dismiss="toast"
            aria-label="Close"
          ></button>
        </div>
        <div class="toast-body">Привет номер твоей заявки {{ requestnumber }}.</div>
      </div>
    </div>
    <!-- <div class="toast show bg-light" role="alert" aria-live="assertive" aria-atomic="true">
      <div class="toast-header">
        <strong class="me-auto">Bootstrap</strong>
        <small>11 mins ago</small>
        <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
      </div>
      <div class="toast-body">Hello, world! This is a toast message.</div>
    </div> -->
  </div>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
import bootstrap from "bootstrap/dist/js/bootstrap.min.js";
import { Toast } from "bootstrap/dist/js/bootstrap.esm.min.js";

// import useStore from vuex
import "animate.css";
// import slider from "vue3-slider"
import Slider from "@vueform/slider";
import axios from "axios";
// import Range from "./range.vue"

export default {
  // props: {
  //   SETTINGS: {
  //     type: Array,
  //     default: () => {
  //       return []
  //     },
  //   },
  // },
  components: {
    Slider,
    // "vue3-slider": slider,
    // Range,
  },
  name: "calc",

  data: () => ({
    // SETTINGS: [{}],
    Price: 1000, // базовое значение цены
    day: 1, // базовое значение дня
    Percent: 0, // итоговое значение процента
    percentDay: 1, // процент в день
    year: 365,
    // TODO: сделать проверку на високосный год
    a: 100, // ячейка для деления на 100
    allsum: 0,
    // date: new Date().toLocaleDateString(),
    // ползунок денег
    stepPrice: 1,
    value: 0,
    maxPrice: 30000, // настройка макс цены в ползунке
    minPrice: 1000, // настройка мин цены в ползунке
    showTooltipPrice: "always",
    // ползунок денег
    //  ползунок дня
    maxday: 30, //настройка макс дня в ползунке
    minday: 1, //настройка мин дня в ползунке
    stepday: 0,
    showTooltipday: "always", //always|focus|drag. //тултип дня
    //  ползунок дня
    // format: {
    //   suffix: " RUB",
    // },
    user: {
      inputtel: "",
      inputname: "",
      inputemail: "",
      // id: 1,
    },
    Id: 0,
    requestnumber: "",
    datenow: "",
    someModal: "",

    
  }),
  // async mounted() {
  //   const res = await fetch("http://localhost:3000/settings")
  //   const settings = await res.json()
  //   this.settings = settings
  // },

  methods: {
    format: function (value) {
      return `${Math.round(value / 1000) * 1000} RUB`;
    },
    formatday: function (value) {
      return `${Math.round(value)} Дн`;
    },
    modalwindow() {
      // this.someModal = new bootstrap.Modal(document.getElementById("takesumm"));

      this.someModal.toggle();
    },
    onclickbtn() {
      // var toastTrigger = document.getElementById("liveToastBtn");
      const toastLiveExample = document.getElementById("liveToast");

      const toast = new bootstrap.Toast(toastLiveExample);

      toast.show();

      // Array.from(document.querySelectorAll(".toast")).forEach((toastNode) => new Toast(toastNode));
    },
    onclick() {
      this.setToast(true);
      // this.$store.dispatch("setToast", true);
      const toast = new Toast(this.$refs.toast);

      toast.show();
      this.setToast(false);
      // this.$store.dispatch("setToast", false);
    },
    ...mapActions(["GET_SETTINGS_FROM_API", "setToast"]),

    alertjs() {
      alert("mem");
      // this.Price = Math.round(this.Price / 1000) * 1000
    },
    outputPercent() {
      //  вычисление процента
      this.day = eval(this.day);
      this.Price = eval(this.Price);
      this.Percent = eval(this.Percent);
      this.percentDay = eval(this.percentDay);
      this.year = eval(this.year);
      this.a = eval(this.a);

      return (this.Percent = Math.round(
        ((this.Price * this.percentDay * this.year) / this.a / this.year) * this.day
      ));
      // return (this.Percent = Math.round(
      //   this.Price * Math.pow(this.percentDay + this.percentDay / this.a, this.day)
      // ))
    },
    outputall() {
      //  сумма процента с заемным числом
      return (this.allsum = Math.round(this.Percent + this.Price));
    },
    dni() {
      // вычисление количества дней
      var date = new Date();
      date.setDate(date.getDate() + Math.trunc(this.day));
      return date.toLocaleDateString();
    },
    totalsum() {
      this.day = eval(this.day);
      this.Price = eval(this.Price);
      this.Percent = eval(this.Percent);
      this.percentDay = eval(this.percentDay);
      this.year = eval(this.year);
      this.a = eval(this.a);
      // return Math.round(100 * Math.pow(1 + 1 / 100, 365))
      // return Math.round(this.Price * Math.pow(this.percentDay + this.percentDay / this.a, this.day))
      // return Math.round(
      //   (Math.round(this.Price * Math.pow(this.percentDay + this.percentDay / this.a, this.day)) /
      //     1000) *
      //     1000
      // )
      // return Math.round(
      //   Math.round(this.Price * ((this.percentDay / 100 / this.year) * this.day) + this.Price)
      // )
      // return this.Price * ((this.percentDay * this.year) / 100) * this.day + this.Price
      return (
        Math.round(this.Price * (((this.percentDay / 100) * this.year) / this.year) * this.day) +
        this.Price
      );
    },

    // Priceroundd() {
    //   console.log(`${this.Price} pop`)
    //   // this.Price = eval(Math.round(this.Price / 1000) * 1000)
    //   // return this.Price
    // },

    // getPrice() {
    //   return (this.Price = 30000)
    // },
    // Priceround() {
    //   if (this.price < 1000) {
    //     console.log(`${this.price}округление не вышло`)
    //     // округление цены
    //     console.log(this.Price)
    //   } // какое количество выбрано //потом повторно сколько округлило
    //   else if (this.price > 1000) {
    //     this.Price = Math.round(this.Price / 1000) * 1000
    //     return this.Price
    //   }
    //
    Priceround() {
      this.Price = Math.round(this.Price / 1000) * 1000;
      return this.Price;
    },
    Priceroundslider() {
      this.Price = Math.round(this.Price / 1000) * 1000;
      return this.Price;
    },

    dayround() {
      console.log(this.day); // какое количество выбрано //потом повторно сколько округлило
      this.day = Math.round(this.day / 1) * 1;
      return this.day;
    },
    anotherThing() {
      function delay(ms) {
        return new Promise((resolve) => setTimeout(resolve, ms));
      }
      delay(0).then(() => this.Priceround());
    },
    anotherThing2() {
      function delay(ms) {
        return new Promise((resolve) => setTimeout(resolve, ms));
      }
      delay(3000).then(() => this.Priceround());
    },

    // test() {
    //   axios({
    //     url: this.$BASERESTURL + "/user/loans",
    //     headers: {
    //       "Content-Type": "application/x-www-form-urlencoded",
    //       "cache-control": "no-cache, no-store",
    //       "content-encoding": "gzip",
    //       "content-type": "text/html; charset=utf-8",
    //       pragma: "no-cache",
    //       vary: "Accept-Encoding",
    //     },
    //     method: "POST",
    //   });
    // },
    openmodal() {
      this.someModal = new bootstrap.Modal(document.getElementById("takesumm"));

      this.someModal.toggle();
    },
    datenowsetter() {
      this.datenow = new Date().toLocaleString();
      // this.datenow = this.datenoww.getFullYear().getMonth().getDate().getHours().getMinutes();
      // this.user = {
      //   id: Date.now(),
      //   inputtel: this.user.inputtel,
      //   inputname: this.user.inputname,
      //   inputemail: this.user.inputemail,
      //   vmodelsumm: this.Price,
      //   vmodelday: this.day,
      //   datenow: this.datenow,
      // };
      this.requestnumber = String(Date.now());
      // this.datenow = Date.now();
    },
    senddatafrommodal() {
      this.datenowsetter();
      axios
        .post("api/Settings/Data", {
          // user: {
          // id: this.id,
          Id: 0,
          requestnumber: this.requestnumber,
          inputtel: this.user.inputtel,
          inputname: this.user.inputname,
          inputemail: this.user.inputemail,
          vmodelsumm: this.Price,
          vmodelday: this.day,
          datenow: this.datenow,

          // },
        })

        .then((Response) => {
          // this.modalwindow();
          // alert(Response.data)
          console.log(Response);
          this.user.inputtel = "";
          this.user.inputname = "";
          this.user.inputemail = "";
          this.modalwindow();
          this.onclick();
        })
        .catch((error) => {
          alert(error);
          console.log(error);
          console.log("ошибка senddatafrommodal");
        });

      //   fetch(BASE_URL + GET_USERS, {
      //     method: "GET",
      //     headers: {
      //       "Content-Type": "application/json",
      //       "Access-Control-ALlow-Origin": "*",
      //     },
      //   })
      //     .then((response) => response.json())
      //     .then((json) => {
      //       // debugger;
      //       console.log(json);
      //     });
    },
  },
  mounted() {
    // this.GET_SETTINGS_FROM_API();
    // axios
    //   .get("api/Settings")
    //   .then(console.log("mounted get"))
    //   .then((Response) => (this.courses = Response.data))
    //   // axios("http://192.168.3.78:5296/db", {
    //   //   method: "GET",
    //   //   headers: {
    //   //     "Content-type": "application/json",
    //   //   },
    //   // })
    //   .then((Response) => {
    //     this.courses = Response.data;
    //     // console.log("hello picca");
    //   })
    //   .catch((error) => {
    //     console.log(error);
    //     console.log("ошибка get moudted");

    //     return error;
    //   });

    this.GET_SETTINGS_FROM_API()
      // скрипт для после прогрузки настроек
      .then((Response) => {
        //if massiv
        console.log(this.SETTINGS[0].percentDay);
        console.log(this.SETTINGS.title);
        console.log(this.SETTINGS.percentDay);

        console.log(this.SETTINGS);
        console.log(typeof SETTINGS);

        if (Response.data) {
          this.percentDay = this.SETTINGS[0].percentDay;

          console.log("data arrived");
        }
      })
      .catch((error) => {
        console.log("EROR: " + error);
        return error;
      });
  },

  // async mounted() {
  //   this.$store.dispatch("fetchSettings")
  // },
  computed: {
    toastState() {
      return this.$store.getters.getToast;
    },
    // добавляем переменную сетингс
    ...mapGetters(["SETTINGS"]),
    // allSettings() {
    //   return this.$store.state.getters.allSettings
    // },
    // minPriceComputed: () => При стрелочной функции теряется контекст this
    minPriceComputed: function () {
      if (this.Price >= 1000) return Math.round(this.totalsum() / 10) * 10;
      else
        return (
          Math.round(
            this.minPrice * (((this.percentDay / 100) * this.year) / this.year) * this.day
          ) + this.minPrice
        );
    },
  },

  emits: {
    // submit: ({ email, password }) => {
    //   if (email && password) {
    //     return true
    //   } else {
    //     console.warn("Некорректные данные для генерации события submit!")
    //     return false
    //   }
    // },
  }, // Эммит на обновление цены

  watch: {
    // eslint-disable-next-line no-unused-vars
    toastState(newT, oldT) {
      if (newT) this.onclick();
    },
    // вочеры на изменение поля цены и дня
    Price() {
      if (this.Price < 90 || this.Price < 900) {
        this.anotherThing2();
      }
      // if (this.Price > 1000) {
      //   this.Priceround()
      // }
      // if (this.Price < 10) {
      //   setTimeout(() => {
      //     // alert("<1000")
      //     console.log(` alert `)
      //     this.Price = Math.round(this.Price * 1000) / 1000
      //   }, 3000)
      // }
      // if (this.Price > 1000) {
      //   if (this.Price % 1000 != 0) {
      //     this.Price = Math.round(this.Price / 1000) * 1000
      //   }
      //   // if (this.Price < 10000) {
      //   //   console.log("<10000")
      //   // }
      //   // if (this.Price > 10000) {
      //   //   this.Priceround()
      //   // }
      // }
      if (this.Price == undefined) {
        // проверка на пустую строку
        return (this.Price = null);
      }
      // if (this.Price == isNaN) {
      //   // проверка на пустую строку
      //   return (this.Price = 1000)
      // }
      if (this.Price == 0) {
        return (this.Price = null);
      }
      if (this.Price > 30000) {
        return (this.Price = 30000);
        // return this.getPrice()
      }
      if (this.Price == 30000) {
        return (this.Price = 30000);
      }
      // if (this.Price < 1000) {
      //   return (this.Price = 1000)
      // }
    },
    // проверка на заполнение больше 30000
    // else {
    //   alert("Произошла непредвиденная ошибка #price0")
    //   console.log("Произошла непредвиденная ошибка #price0")
    // }

    day() {
      this.dayround();
      if (this.day == undefined) {
        // проверка на пустую строку
        return (this.day = null);
      }

      if (this.day > 30) return (this.day = 30);

      // проверка на заполнение больше 30 дней
      // else {
      //   alert("Произошла непредвиденная ошибка #day0")
      //   console.log("Произошла непредвиденная ошибка #day0")
    },
  },
};

// mounted() {
//   this.interval = setInterval(() => {
//     this.date = new Date()
//   }, 60000)
// },
// если на странице не будет использоваться функция времени то следующий хук стирает его
// что бы не было утечки памяти
// beforemounted() {
//   clearInterval(this.interval)
// },
//const isLeapYear = year => !(year % 100) ? !(year % 400) : !(year % 4);
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>
/* src="@vueform/slider/themes/default.css" */
.slider-red {
  --slider-connect-bg: #ef4444;
  --slider-tooltip-bg: #ef4444;
  --slider-handle-border: 50px;
  --slider-handle-ring-color: #b8f5eb;
}

.slider-blue {
  --slider-bg: #b8f5eb;
  --slider-connect-bg: #3b82f6;
  --slider-tooltip-bg: #3b82f6;
  --slider-handle-ring-color: #3bf66a7e;
  --slider-handle-shadow: 0.5px 0.5px 2px 1px rgba(83, 184, 209, 0.418);
  --slider-handle-shadow-active: 0.5px 0.5px 2px 1px rgba(160, 46, 46, 0.42);
  --slider-height: 30px;
  /* --slider-width: 30px; */

  --slider-handle-height: 30px;
  --slider-handle-width: 30px;
  --slider-handle-border: 0px;
  --slider-vertical-height: 3000px;
  --slider-radius: 50px;
}
.slider-pips {
  display: flex;
  justify-content: space-evenly;
}

h3 {
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
}
input:invalid {
  border: 2px dashed red;
}

input:invalid:required {
  background-image: linear-gradient(to right, pink, lightgreen);
}

/* range style */
</style>
<style src="@vueform/slider/themes/default.css"></style>
