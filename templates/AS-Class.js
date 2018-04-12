
// Java includes -> important: leave first line empty

/**
 * Code documentation
 *
 * @author TE, HOLME Consulting & Solutions
 * @version 1.00.000
 *
 * @requires my.namespace.MySuperclass
 * @requires my.namespace.MyMixin
 */
sol.define("my.namespace.MyClass", {
  singleton: true,
  extend: "my.namespace.MySuperclass",
  mixins: ["my.namespace.MyMixin"],

  // properties section

  // optional
  initialize: function (config) {

  },

  // implementation section
  process: function () {}
});