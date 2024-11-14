window.resizeObserver = {
    observe: function (dotNetObject) {
        const resizeObserver = new ResizeObserver(entries => {
            for (let entry of entries) {
                const width = entry.contentRect.width;
                dotNetObject.invokeMethodAsync('OnResize', width);
            }
        });

        resizeObserver.observe(document.body);
    }
};