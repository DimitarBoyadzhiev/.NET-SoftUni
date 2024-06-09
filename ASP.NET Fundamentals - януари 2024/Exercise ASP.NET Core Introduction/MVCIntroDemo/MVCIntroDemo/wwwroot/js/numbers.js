function SetLimit(num) {
    let num = document.getElementById("limitInput").value || 50;

    window.location = "https://localhost:7279/Numbers/Limit?num=" + num;
}