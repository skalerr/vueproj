<template>
  <!-- v-model="Price" :tooltip="true" tooltipText="%v" -->
  <div class="container-md">
    <div class="row" style="height: 500px">
      <!-- col-lg-6 col-sm-6 -->
      <div class="col-lg-12 col-sm-12 mb-3">
        <div class="product-card card text-dark bg-light mb-3 ms-3">
          <!-- наполнение карточки -->
          <h5 class="card-header">Card</h5>
          <div class="card-body">
            <div class="container-md">
              <div class="row">
                <div class="d-md-flex justify-content-around">
                  <div class="range-slider col">
                    <div class="col d-flex justify-content-between">
                      <p class="d-flex justify-content-between flex-grow-1 mb-0">
                        <small>
                          <span class="border opop user-select-none">{{
                            `${minPrice} RUB`
                          }}</span> </small
                        ><small>
                          <span class="border user-select-none">{{
                            `${maxPrice} RUB`
                          }}</span></small
                        >
                      </p>
                    </div>
                    <!-- ranger -->
                    <div class="range_container">
                      <!--  слайдер -->
                      <Slider
                        id="slider"
                        v-model="Price"
                        :format="format"
                        class="slider-blue"
                        :max="maxPrice"
                        :step="stepPrice"
                        :min="minPrice"
                        :showTooltip="showTooltipPrice"
                      />
                    </div>
                    <div class="d-flex justify-content-start ps-3 pt-2">
                      <!-- <input v-bind:value="Price" /> 
                    поле ввода с привзкой к значению но без редактирования -->

                      <input
                        v-model.lazy.number="Price"
                        type="number"
                        min="1000"
                        max="30000"
                        step="1000"
                        style="width: 200px"
                        class="form-control"
                        required
                      />
                      <!-- minlength="4" -->
                      <button type="submit" class="btn btn-primary ps-2 ms-2">Посчитать</button>
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
                      />
                    </div>
                    <div class="col d-flex justify-content-between">
                      <!-- числа слева и справа 1 и 30 -->
                      <p class="d-flex justify-content-between flex-grow-1">
                        <small>
                          <span class="border user-select-none">{{ `${minday} Дн` }}</span>
                        </small>
                        <small>
                          <span class="border user-select-none">{{ `${maxday} Дн` }}</span>
                        </small>
                      </p>
                    </div>
                    <div class="d-flex justify-content-start ps-3 pt-1">
                      <!-- поле ввода для дня -->
                      <input
                        oninput="this.value = Math.round((this.value / 1) * 1);"
                        v-model.number="day"
                        type="number"
                        min="1"
                        max="30"
                        step="1"
                        style="width: 200px"
                        class="form-control"
                      />
                    </div>
                  </div>
                  <div class="range-values col-4">
                    <div class="card text-dark border-success mb-3 ms-3">
                      <div class="card-header">Хедер</div>
                      <div class="card-body">
                        <h5 class="card-title">
                          <!-- <p v-if="Price >= minPrice">Итого {{ outputall() }} рублей</p>
                          <p v-else-if="Price < minPrice">
                            Итого {{ Math.round((allsum = this.Percent + minPrice)) }} рублей
                          </p> -->
                          <p>Итого {{ outputall() }} рублей</p>
                        </h5>
                        <p class="card-text"></p>
                        <!-- <p v-if="Price >= minPrice">Сумма: {{ Price }} рублей</p>
                        <p v-else-if="Price < minPrice">Сумма: {{ minPrice }} рублей</p> -->
                        <p>Сумма: {{ Price }} рублей</p>
                        <p>На какое количество дней: {{ day }} дней</p>
                        <p hidden>
                          Процент который нужно будет оплатить
                          {{ outputPercent() }} рублей
                        </p>
                        <p hidden>Итого {{}} {{ allsum }} рублей</p>
                        <p>К какой дате необходимо вернуть {{ dni() }}</p>
                        <p></p>
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
  </div>
</template>

<script>
// TODO //ТУЛТИП ОКРУГЛЕНИЕ
import "animate.css"
// import slider from "vue3-slider"
import Slider from "@vueform/slider"
// import Range from "./range.vue"
export default {
  components: {
    Slider,
    // "vue3-slider": slider,
    // Range,
  },
  name: "calc3",

  data: () => ({
    Price: 1000, // базовое значение цены
    day: 1, // базовое значение дня
    Percent: 0, // итоговое значение процента
    PercentDay: 1, // процент в день
    year: 365,
    // TODO: сделать проверку на високосный год
    a: 100, // ячейка для деления на 100
    allsum: 0,
    // date: new Date().toLocaleDateString(),
    // ползунок денег
    stepPrice: 1,
    value: 0,
    maxPrice: 30000,
    minPrice: 1000,
    showTooltipPrice: "always",
    // ползунок денег
    //  ползунок дня
    maxday: 30,
    minday: 1,
    stepday: 0,
    showTooltipday: "always", //always|focus|drag.
    //  ползунок дня
    // format: {
    //   suffix: " RUB",
    // },
    format: function (value) {
      return `${Math.round(value / 1000) * 1000} RUB`
    },
    formatday: function (value) {
      return `${Math.round(value)} Дн`
    },
  }),
  props: {},
  methods: {
    // dateFilter(date) {
    //   const options = {
    //     year: "numeric",
    //     month: "numeric",
    //     day: "numeric",
    //     hour12: false,
    //   }
    //   return new Intl.DateTimeFormat("ru-RU", options).format(new Date(date))
    // },

    outputPercent() {
      //  вычисление процента
      this.day = eval(this.day)
      this.Price = eval(this.Price)
      this.Percent = eval(this.Percent)
      this.PercentDay = eval(this.PercentDay)
      this.year = eval(this.year)
      this.a = eval(this.a)
      // this.Percent = Math.round(
      //   ((this.Price * this.PercentDay * this.year) / this.a / this.year) * this.day
      // )
      // return this.Percent
      return Math.round(
        ((this.Percent = this.Price * this.PercentDay * this.year) / this.a / this.year) * this.day
      )
    },

    outputall() {
      //  сумма процента с заемным числом
      return Math.round((this.allsum = this.Percent + this.Price))

      // this.allsum = Math.round(this.Percent + this.Price)
      // return this.allsum
    },

    dni() {
      // вычисление количества дней
      var date = new Date()
      date.setDate(date.getDate() + Math.trunc(this.day))
      return date.toLocaleDateString()
    },
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
    Priceround() {
      if (this.Price > 1000) {
        this.Price = Math.round(this.Price / 1000) * 1000
        return this.Price
      }
      // if (this.Price > 10000) {
      //   this.Price = Math.round(this.Price / 10000) * 10000
      //   return this.Price
      // }
      // else if (this.Price < 1000) {
      //   // this.Price = 1000
      //   this.Price = Math.round(this.Price / 1000) * 1000
      //   return this.Price
      // }
    },
    dayround() {
      console.log(this.day) // какое количество выбрано //потом повторно сколько округлило
      this.day = Math.round(this.day / 1) * 1
      return this.day
    },
  },
  computed: {},

  // emits: ["update:Price"], // Эммит на обновление цены

  watch: {
    // Price() {
    //   this.Priceround()
    // },

    // вочеры на изменение поля цены и дня
    Price() {
      this.Priceround()

      if (this.Price == undefined) {
        // проверка на пустую строку
        return (this.Price = null)
      }
      // if (this.Price == isNaN) {
      //   // проверка на пустую строку
      //   return (this.Price = 1000)
      // }

      if (this.Price > 30000) {
        return (this.Price = 30000)
        // return this.getPrice()
      }
      if (this.Price == 30000) {
        return (this.Price = 30000)
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
      this.dayround()
      if (this.day == undefined) {
        // проверка на пустую строку
        return (this.day = null)
      }

      if (this.day > 30) return (this.day = 30)

      // проверка на заполнение больше 30 дней
      // else {
      //   alert("Произошла непредвиденная ошибка #day0")
      //   console.log("Произошла непредвиденная ошибка #day0")
    },
  },
}

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
  --slider-handle-height: 30px;
  --slider-handle-width: 30px;
  --slider-handle-border: 0px;
  --slider-vertical-height: 3000px;
  --slider-radius: 50px;
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
